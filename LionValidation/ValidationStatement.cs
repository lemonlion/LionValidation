using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation
{
    public class ValidationStatement
    {
        private string dependantFieldName;
        private Operator _operator;
        private object comparisonValueOrFieldNameOrRegex;
        private string dateFormat;

        public string DateFormat { get { return dateFormat; } }
        public string DependantFieldName { get { return dependantFieldName;  } }
        public Operator Operator { get { return _operator; } }
        public object ComparisonValueOrFieldNameOrRegex 
        {
            get
            {
                if (comparisonValueOrFieldNameOrRegex is DateOf)
                    return GetDateStringFromRelativeDate((DateOf)comparisonValueOrFieldNameOrRegex);
                
                if ((Operator.ToString().Contains("MoreRecent") || Operator.ToString().Contains("Older")) &&
                         (comparisonValueOrFieldNameOrRegex.ToString().ToLower().Contains("ago") ||
                          comparisonValueOrFieldNameOrRegex.ToString().ToLower().Contains("from now")))
                    return GetDateStringFromRelativeDateString(comparisonValueOrFieldNameOrRegex.ToString());

                return comparisonValueOrFieldNameOrRegex;
            }
        }

        private object dependantFieldValue;
        private object comparisonValue;

        public ValidationStatement(string dependantFieldName, Operator _operator, object comparisonValueOrFieldNameOrRegex, string dateFormat = "")
        {
            this.dependantFieldName = (dependantFieldName == string.Empty) ? "this" : dependantFieldName;
            this._operator = _operator;
            this.comparisonValueOrFieldNameOrRegex = comparisonValueOrFieldNameOrRegex;
            this.dateFormat = dateFormat != "" ? dateFormat : CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
        }

        public bool Evaluate(object objectInstance, object thisFieldValue = null)
        {
            bool result = false;

            dependantFieldValue = (DependantFieldName == "this") ? thisFieldValue : objectInstance.GetPropertyValueWithDotNotation(DependantFieldName);

            if (Operator == Operator.MatchesRegularExpression)
            {
                result = dependantFieldValue != null && Regex.IsMatch(dependantFieldValue.ToString(), ComparisonValueOrFieldNameOrRegex.ToString());
            }
            else if (Operator == Operator.FailsRegularExpression)
            {
                result = dependantFieldValue == null || !Regex.IsMatch(dependantFieldValue.ToString(), ComparisonValueOrFieldNameOrRegex.ToString());
            }
            else
            {
                if (Operator.ToString().EndsWith("Field"))
                    comparisonValue = objectInstance.GetPropertyValueWithDotNotation(ComparisonValueOrFieldNameOrRegex.ToString());
                else
                    comparisonValue = ComparisonValueOrFieldNameOrRegex;
                
                string dependantFieldValueString = dependantFieldValue != null ? dependantFieldValue.ToString() : string.Empty;
                string comparisonValueString = comparisonValue != null ? comparisonValue.ToString() : string.Empty;

                double? dependantFieldValueDouble = null;
                double? comparisonValueDouble = null;
                double tempDouble;

                DateTime? dependantFieldValueDate = null;
                DateTime? comparisonValueDate = null;
                DateTime tempDate;

                if (Operator.ToString().Contains("Numerically") || Operator.ToString().Contains("GreaterThan") || Operator.ToString().Contains("LessThan"))
                {
                    dependantFieldValueDouble = double.TryParse(dependantFieldValueString, out tempDouble) ? tempDouble : (double?)null;
                    comparisonValueDouble = double.TryParse(comparisonValueString, out tempDouble) ? tempDouble : (double?)null;

                    if (dependantFieldValueDouble == null || comparisonValueDouble == null)
                        return result; // Failed validation since at least one variable is not a number
                }
                else if (Operator.ToString().Contains("Older") || Operator.ToString().Contains("MoreRecent") || Operator.ToString().Contains("Date"))
                {
                    dependantFieldValueDate = DateTime.TryParseExact(dependantFieldValueString, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDate) ? tempDate : (DateTime?)null;

                    if (comparisonValue is DateOf)
                        comparisonValueDate = GetDateFromRelativeDate((DateOf)comparisonValue);
                    else if (comparisonValue is String && comparisonValue.ToString().ToLower().Contains("ago") && comparisonValue.ToString().ToLower().Contains("from now"))
                        comparisonValueDate = GetDateFromRelativeDateString(comparisonValue.ToString());
                    else
                        comparisonValueDate = DateTime.TryParseExact(comparisonValueString, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out tempDate) ? tempDate : (DateTime?)null;

                    if (dependantFieldValueDate == null || comparisonValueDate == null)
                        return result; // Failed validation since at least one variable is not a date
                }

                switch (Operator)
                {
                    case Operator.GreaterThan:
                    case Operator.GreaterThanField:
                        result = dependantFieldValueDouble > comparisonValueDouble; break;

                    case Operator.GreaterThanOrEqualTo:                  
                    case Operator.GreaterThanOrEqualToField:
                        result = dependantFieldValueDouble >= comparisonValueDouble; break;

                    case Operator.LessThan:
                    case Operator.LessThanField:
                        result = dependantFieldValueDouble < comparisonValueDouble; break;

                    case Operator.LessThanOrEqualTo:
                    case Operator.LessThanOrEqualToField:
                        result = dependantFieldValueDouble <= comparisonValueDouble; break;

                    case Operator.NumericallyEqualTo:
                    case Operator.NumericallyEqualToField:
                        result = dependantFieldValueDouble == comparisonValueDouble; break;

                    case Operator.NumericallyNotEqualTo:
                    case Operator.NumericallyNotEqualToField:
                        result = dependantFieldValueDouble != comparisonValueDouble; break;

                    case Operator.EqualTo:
                    case Operator.EqualToField:
                        result = dependantFieldValueString == comparisonValueString; break;

                    case Operator.NotEqualTo:
                    case Operator.NotEqualToField:
                        result = dependantFieldValueString != comparisonValueString; break;

                    case Operator.LongerThan:
                        result = comparisonValueString.IsInt() && dependantFieldValueString.Length > int.Parse(comparisonValueString); break;
                    case Operator.LongerThanField:
                        result = dependantFieldValueString.Length > comparisonValueString.Length; break;

                    case Operator.LongerOrLengthEqualTo:
                        result = comparisonValueString.IsInt() && dependantFieldValueString.Length >= int.Parse(comparisonValueString); break;
                    case Operator.LongerOrLengthEqualToField:
                        result = dependantFieldValueString.Length >= comparisonValueString.Length; break;

                    case Operator.ShorterThan:
                        result = comparisonValueString.IsInt() && dependantFieldValueString.Length < int.Parse(comparisonValueString); break;
                    case Operator.ShorterThanField:
                        result = dependantFieldValueString.Length < comparisonValueString.Length; break;

                    case Operator.ShorterOrLengthEqualTo:
                        result = comparisonValueString.IsInt() && dependantFieldValueString.Length <= int.Parse(comparisonValueString); break;
                    case Operator.ShorterOrLengthEqualToField:
                        result =  dependantFieldValueString.Length <= comparisonValueString.Length; break;

                    case Operator.LengthEqualTo:
                        result = comparisonValueString.IsInt() && dependantFieldValueString.Length == int.Parse(comparisonValueString); break;
                    case Operator.LengthEqualToField:
                        result = dependantFieldValueString.Length == comparisonValueString.Length; break;

                    case Operator.LengthNotEqualTo:
                        result = comparisonValueString.IsInt() && dependantFieldValueString.Length != int.Parse(comparisonValueString); break;
                    case Operator.LengthNotEqualToField:
                        result = dependantFieldValueString.Length != comparisonValueString.Length; break;

                    case Operator.Contains:
                    case Operator.ContainsField:
                        result = dependantFieldValueString.Contains(comparisonValueString); break;

                    case Operator.DoesntContain:
                    case Operator.DoesntContainField:
                        result = !dependantFieldValueString.Contains(comparisonValueString); break;

                    case Operator.MoreRecentThan:
                    case Operator.MoreRecentThanField:
                        result = dependantFieldValueDate > comparisonValueDate; break;

                    case Operator.MoreRecentThanOrEqualTo:
                    case Operator.MoreRecentThanOrEqualToField:
                        result = dependantFieldValueDate >= comparisonValueDate; break;

                    case Operator.OlderThan:
                    case Operator.OlderThanField:
                        result = dependantFieldValueDate < comparisonValueDate; break;

                    case Operator.OlderThanOrEqualTo:
                    case Operator.OlderThanOrEqualToField:
                        result = dependantFieldValueDate <= comparisonValueDate; break;

                    case Operator.DateEqualTo:
                    case Operator.DateEqualToField:
                        result = dependantFieldValueDate == comparisonValueDate; break;

                    case Operator.DateNotEqualTo:
                    case Operator.DateNotEqualToField:
                        result = dependantFieldValueDate != comparisonValueDate; break;

                }
            }

            return result;
        }

        public string GetDateStringFromRelativeDate(DateOf relativeDate)
        {
            return GetDateFromRelativeDate(relativeDate).ToString(DateFormat);
        }

        public DateTime GetDateFromRelativeDate(DateOf relativeDate)
        {
            if (relativeDate == DateOf.Today) return DateTime.Now;
            if (relativeDate == DateOf.Tomorrow) return DateTime.Now.AddDays(1);
            if (relativeDate == DateOf.Today) return DateTime.Now.AddDays(-1);

            DateTime date = new DateTime();
            int number = GetNumberFromRelativeDate(relativeDate);
            bool past = relativeDate.ToString().Contains("Ago");

            number = past ? 0 - number : number;

            if (relativeDate.ToString().Contains("Year"))
                date = DateTime.Now.AddYears(number);
            else if (relativeDate.ToString().Contains("Month"))
                date = DateTime.Now.AddMonths(number);
            else if (relativeDate.ToString().Contains("Day"))
                date = DateTime.Now.AddDays(number);

            return date;
        }

        public string GetDateStringFromRelativeDateString(string relativeDate)
        {
            return GetDateFromRelativeDateString(relativeDate).ToString(DateFormat);
        }

        public DateTime GetDateFromRelativeDateString(string relativeDate)
        {
            relativeDate = relativeDate.ToLower();
            DateTime date = DateTime.Now;
            int numberOfYears = 0;
            int numberOfMonths = 0;
            int numberOfDays = 0;

            if ((!relativeDate.Contains("year") && !relativeDate.Contains("month") && !relativeDate.Contains("days")) ||
                (!relativeDate.Contains("ago") && !relativeDate.Contains("from now")) || // Either 'ago' or 'from now'
                (relativeDate.Contains("ago") && relativeDate.Contains("from now")))     // ...but not both
                throw new Exception("Invalid format for relative date.  Relative date string must end with 'from now' or 'ago' and string must contain a statement in the format of one or more of the following: 'x days', 'x months', 'x years'.  eg. '4 months 21 days ago'");

            try
            {
                numberOfYears = relativeDate.Contains("year")
                    ? int.Parse(relativeDate.ToLower().Split("year")[0].Trim().Split(' ').Last())
                    : 0;
                numberOfMonths = relativeDate.Contains("month")
                    ? int.Parse(relativeDate.ToLower().Split("month")[0].Trim().Split(' ').Last())
                    : 0;
                numberOfDays = relativeDate.Contains("day")
                    ? int.Parse(relativeDate.ToLower().Split("day")[0].Trim().Split(' ').Last())
                    : 0;
            }
            catch (Exception e)
            {
                throw new Exception("Invalid format for relative date.  Relative date string must end with 'from now' or 'ago' and string must contain a statement in the format of one or more of the following: 'x days', 'x months', 'x years'.  eg. '4 months 21 days ago'");
            }

            bool past = relativeDate.ToLower().Contains("ago");

            if (past)
            {
                numberOfYears = 0 - numberOfYears;
                numberOfMonths = 0 - numberOfMonths;
                numberOfDays = 0 - numberOfDays;
            }

            date = date.AddYears(numberOfYears);
            date = date.AddMonths(numberOfMonths);
            date = date.AddDays(numberOfDays);

            return date;
        }

        public static int GetNumberFromRelativeDate(DateOf relativeDate)
        {
            string numberString =
                relativeDate.GetDescription()
                    .ToLower()
                    .Replace("ago", "")
                    .Replace("fromnow", "")
                    .Replace("years", "")
                    .Replace("months", "")
                    .Replace("days", "")
                    .Replace("year", "")
                    .Replace("month", "")
                    .Replace("day", "");

            var numberTable = new Dictionary<string, int>
            {{"zero", 0},{"one", 1},{"two", 2},{"three", 3},{"four", 4},
            {"five", 5},{"six", 6},{"seven", 7},{"eight", 8},{"nine", 9},
            {"ten", 10},{"eleven", 11},{"twelve", 12},{"thirteen", 13},
            {"fourteen", 14},{"fifteen", 15},{"sixteen", 16},
            {"seventeen", 17},{"eighteen",18},{"nineteen", 19},{"twenty", 20},
            {"thirty", 30},{"forty", 40},{"fifty", 50},{"sixty", 60},
            {"seventy", 70},{"eighty", 80},{"ninety", 90},{"hundred", 100}};

            var numbers = Regex.Matches(numberString, @"\w+").Cast<Match>()
                 .Select(m => m.Value.ToLowerInvariant())
                 .Where(numberTable.ContainsKey)
                 .Select(v => numberTable[v]);

            int acc = 0, total = 0;
            
            foreach (var n in numbers)
            {
                if (n >= 1000)
                {
                    total += (acc * n);
                    acc = 0;
                }
                else if (n >= 100)
                    acc *= n;
                else 
                    acc += n;
            }

            return (total + acc);
        }
    }
}