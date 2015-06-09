using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using LionValidation.Enums;
using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation
{
    public class Validator
    {
        private readonly string lambdaExpressionFieldName;
        private string lambdaBody;
        private string lambdaParameter;

        private readonly Bracket? openingBrackets;
        private readonly List<ValidationStatement> validationStatements = new List<ValidationStatement>();
        private readonly List<AndOr> conjunctions = new List<AndOr>();

        private MustBeAttribute validationAttribute { get; set; }

        public Validator(string lambdaExpressionOrExpressionFieldName)
        {
            if (lambdaExpressionOrExpressionFieldName.Contains("=>"))
            {
                lambdaParameter = lambdaExpressionOrExpressionFieldName.Split(new string[] { "=>" }, StringSplitOptions.None)[0].Trim();
                lambdaBody = lambdaExpressionOrExpressionFieldName.Split(new string[] { "=>" }, StringSplitOptions.None)[1].Trim();
            }
            else // pointer to lambda property
            {
                lambdaExpressionFieldName = lambdaExpressionOrExpressionFieldName;
            }
        }

        public Validator(string dependantField, Operator operatorValue, string dateFormat, params string[] valuesOrFieldNamesOrRegularExpressions)
        {
            validationStatements = new List<ValidationStatement>();
            conjunctions = new List<AndOr>();

            dateFormat = !string.IsNullOrWhiteSpace(dateFormat) ? dateFormat : CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;

            dependantField = string.IsNullOrEmpty(dependantField) ? "this" : dependantField;

            validationStatements.Add(new ValidationStatement(dependantField, operatorValue, valuesOrFieldNamesOrRegularExpressions[0], dateFormat));

            for (int i = 1; i < valuesOrFieldNamesOrRegularExpressions.Count(); i++)
            {
                conjunctions.Add(AndOr.Or);
                validationStatements.Add(new ValidationStatement(dependantField, operatorValue, valuesOrFieldNamesOrRegularExpressions[i], dateFormat));
            }
        }

        public Validator(Bracket? openingBrackets, string dateFormat,
                         string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr? andOr1 = null,
                         string dependantField2 = null, Operator? operatorValue2 = null, object valueOrFieldNameOrRegularExpression2 = null, AndOr? andOr2 = null,
                         string dependantField3 = null, Operator? operatorValue3 = null, object valueOrFieldNameOrRegularExpression3 = null, AndOr? andOr3 = null,
                         string dependantField4 = null, Operator? operatorValue4 = null, object valueOrFieldNameOrRegularExpression4 = null, AndOr? andOr4 = null,
                         string dependantField5 = null, Operator? operatorValue5 = null, object valueOrFieldNameOrRegularExpression5 = null, AndOr? andOr5 = null,
                         string dependantField6 = null, Operator? operatorValue6 = null, object valueOrFieldNameOrRegularExpression6 = null, AndOr? andOr6 = null,
                         string dependantField7 = null, Operator? operatorValue7 = null, object valueOrFieldNameOrRegularExpression7 = null)
        {
            dateFormat = !string.IsNullOrWhiteSpace(dateFormat) ? dateFormat : CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;

            validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField1) ? "this" : dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, dateFormat));
            
            if (!string.IsNullOrWhiteSpace(dependantField2))
            {
                conjunctions.Add(andOr1.Value);
                validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField2) ? "this" : dependantField2, operatorValue2.Value, valueOrFieldNameOrRegularExpression2, dateFormat));
            }

            if (!string.IsNullOrWhiteSpace(dependantField3))
            {
                conjunctions.Add(andOr2.Value);
                validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField3) ? "this" : dependantField3, operatorValue3.Value, valueOrFieldNameOrRegularExpression3, dateFormat));
            }

            if (!string.IsNullOrWhiteSpace(dependantField4))
            {
                conjunctions.Add(andOr3.Value);
                validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField4) ? "this" : dependantField4, operatorValue4.Value, valueOrFieldNameOrRegularExpression4, dateFormat));
            }

            if (!string.IsNullOrWhiteSpace(dependantField5))
            {
                conjunctions.Add(andOr4.Value);
                validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField5) ? "this" : dependantField5, operatorValue5.Value, valueOrFieldNameOrRegularExpression5, dateFormat));
            }

            if (!string.IsNullOrWhiteSpace(dependantField6))
            {
                conjunctions.Add(andOr5.Value);
                validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField6) ? "this" : dependantField6, operatorValue6.Value, valueOrFieldNameOrRegularExpression6, dateFormat));
            }

            if (!string.IsNullOrWhiteSpace(dependantField7))
            {
                conjunctions.Add(andOr6.Value);
                validationStatements.Add(new ValidationStatement(string.IsNullOrEmpty(dependantField7) ? "this" : dependantField7, operatorValue7.Value, valueOrFieldNameOrRegularExpression7, dateFormat));
            }

            this.openingBrackets = openingBrackets;
        }

        public bool Evaluate(object objectInstance, object thisFieldValue = null, Bracket? closingBrackets = null)
        {
            Type modelType = objectInstance.GetType();
            bool result = false;

            if (!string.IsNullOrWhiteSpace(lambdaExpressionFieldName))
            {
                LambdaExpression isValidLambdaExpression = (LambdaExpression)objectInstance.GetPropertyValueWithDotNotation(lambdaExpressionFieldName);
                result = (bool)isValidLambdaExpression.Compile().DynamicInvoke(Convert.ChangeType(objectInstance, modelType));
            }
            else if (!string.IsNullOrWhiteSpace(lambdaBody))
            {
                ParameterExpression parameter = Expression.Parameter(modelType, lambdaParameter);
                LambdaExpression isValidLambdaExpression = System.Linq.Dynamic.DynamicExpression.ParseLambda(new[] { parameter }, typeof(bool), lambdaBody, Convert.ChangeType(objectInstance, modelType));
                result = (bool)isValidLambdaExpression.Compile().DynamicInvoke(Convert.ChangeType(objectInstance, modelType));
            }
            else
            {
                string expressionString = string.Empty;

                if (openingBrackets != null)
                {
                    switch (openingBrackets)
                    {
                        case Bracket.C:
                            expressionString += "(";
                            break;
                        case Bracket.CC:
                            expressionString += "((";
                            break;
                        case Bracket.CCC:
                            expressionString += "(((";
                            break;
                    }
                }

                for (int i = 0; i < validationStatements.Count; i++)
                {
                    expressionString += validationStatements[i].Evaluate(objectInstance, thisFieldValue).ToString().ToLower() + " ";

                    if (i < conjunctions.Count())
                    {
                        switch (conjunctions[i])
                        {
                            case AndOr.And:
                                expressionString += "&&";
                                break;
                            case AndOr.And_C:
                                expressionString += "&& (";
                                break;
                            case AndOr.Ɔ_And:
                                expressionString += ") &&";
                                break;
                            case AndOr.Ɔ_And_C:
                                expressionString += ") && (";
                                break;
                            case AndOr.ƆƆ_And:
                                expressionString += ")) &&";
                                break;
                            case AndOr.And_CC:
                                expressionString += "&& ((";
                                break;
                            case AndOr.ƆƆ_And_C:
                                expressionString += ")) && (";
                                break;
                            case AndOr.Ɔ_And_CC:
                                expressionString += ") && ((";
                                break;
                            case AndOr.ƆƆ_And_CC:
                                expressionString += ")) && ((";
                                break;
                            case AndOr.Or:
                                expressionString += "||";
                                break;
                            case AndOr.Or_C:
                                expressionString += "|| (";
                                break;
                            case AndOr.Ɔ_Or:
                                expressionString += ") ||";
                                break;
                            case AndOr.Ɔ_Or_C:
                                expressionString += ") || (";
                                break;
                            case AndOr.ƆƆ_Or:
                                expressionString += ")) ||";
                                break;
                            case AndOr.Or_CC:
                                expressionString += "|| ((";
                                break;
                            case AndOr.ƆƆ_Or_C:
                                expressionString += ")) || (";
                                break;
                            case AndOr.Ɔ_Or_CC:
                                expressionString += ") || ((";
                                break;
                            case AndOr.ƆƆ_Or_CC:
                                expressionString += ")) || ((";
                                break;
                        }
                    }
                }

                if (closingBrackets != null)
                {
                    switch (closingBrackets)
                    {
                        case Bracket.Ɔ:
                            expressionString += ")";
                            break;
                        case Bracket.ƆƆ:
                            expressionString += "))";
                            break;
                        case Bracket.ƆƆƆ:
                            expressionString += ")))";
                            break;
                    }
                }

                expressionString = expressionString.TrimEnd();

                result = EvaluateExpression(expressionString);
            }

            return result;
        }

        public string ClientSideExpression(Type baseType)
        {
            if (!string.IsNullOrWhiteSpace(lambdaExpressionFieldName) || !string.IsNullOrWhiteSpace(lambdaBody))
            {
                if (!string.IsNullOrWhiteSpace(lambdaExpressionFieldName))
                {
                    LambdaExpression isValidLambdaExpression = (LambdaExpression)baseType.GetStaticPropertyValueWithDotNotation(lambdaExpressionFieldName);
                    lambdaBody = isValidLambdaExpression.Body.ToString().Replace(" AndAlso ", " && ").Replace(" OrElse ", " || ");
                    lambdaParameter = isValidLambdaExpression.Parameters[0].ToString();
                }

                string javascriptExpression = lambdaBody;

                const string arbitraryPlaceHolder = "€ov#%3425432€ov#%";

                var stringsInQuotesStore = new List<string>();
                javascriptExpression = Regex.Replace(javascriptExpression, @"""(?:[^""\\]|\\.)*""",
                                       delegate(Match thisMatch)
                                       {
                                           stringsInQuotesStore.Add(thisMatch.Value);
                                           return arbitraryPlaceHolder;
                                       }, RegexOptions.Multiline);


                const string prefixGroup = @"([ |\(&=\>\<\\\*+:?])";
                const string suffixGroup = @"([ |\(&=\>\<\\\*+:?])";

                const string convertTrueBoolRegexPattern = prefixGroup + @"Convert\(True\)" + suffixGroup;
                const string convertFalseBoolRegexPattern = prefixGroup + @"Convert\(False\)" + suffixGroup;

                // Fix true & false boolean's case problem after ToString method
                javascriptExpression = Regex.Replace(" " + javascriptExpression, convertTrueBoolRegexPattern, @"$1" + "true" + "$2", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Replace("\"", "'").Trim();
                javascriptExpression = Regex.Replace(" " + javascriptExpression, convertFalseBoolRegexPattern, @"$1" + "false" + "$2", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Replace("\"", "'").Trim();

                // Mark out property names
                string propertyNamesRegexPattern = prefixGroup + @"(" + lambdaParameter + @"\.)" + suffixGroup;
                javascriptExpression = Regex.Replace(" " + javascriptExpression, propertyNamesRegexPattern, @"$1" + "{" + @"$3" + "}" + "$4", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Replace("\"", "'").Trim();

                // Deal with converting boolean strings on client side to bools
                var propertyNames = Regex.Matches(" " + javascriptExpression, @"{([a-zA-Z0-9_\.\[\]]*)}");

                for (int i = 0; i < propertyNames.Count; i++)
                {
                    string propertyName = propertyNames[i].Value.Replace("{", string.Empty).Replace("}", string.Empty); ;
                    if (baseType.GetPropertyInfoWithDotNotation(propertyName).PropertyType == typeof(bool))
                        javascriptExpression = javascriptExpression.Replace("{" + propertyName + "}", "LionSpace.toBool({" + propertyName + "})");
                }

                // Fix ToString
                javascriptExpression = javascriptExpression.Replace(".ToString(", ".toString(");
                javascriptExpression = javascriptExpression.Replace("Int.Parse(", "Int.Parse");
                javascriptExpression = javascriptExpression.Replace("Double.Parse(", "parseFloat(");
                javascriptExpression = javascriptExpression.Replace(".Length", ".length");
                javascriptExpression = javascriptExpression.Replace(".Contains", ".lionStringContains");

                int count = -1;

                // Step 3, swap the string bodies back
                javascriptExpression = Regex.Replace(javascriptExpression, arbitraryPlaceHolder,
                           delegate(Match thisMatch)
                           {
                               count++;
                               return "'" + stringsInQuotesStore[count] + "'";
                           }, RegexOptions.Multiline);
                
                return javascriptExpression.Trim();
            }

            return string.Empty;
        }

        public bool UseSimpleClientSideValidation
        {
            get
            {
                return string.IsNullOrEmpty(lambdaExpressionFieldName) && 
                       string.IsNullOrEmpty(lambdaBody) && 
                       string.IsNullOrEmpty(lambdaParameter) && 
                       (!conjunctions.Any() || conjunctions.TrueForAll(x => !x.ToString().Contains("Bracket")));
            }
        }

        public string GetClientSideDependentFields(Type baseType, PropertyInfo thisProperty)
        {   
            string dependantFieldsListString = string.Empty;
            foreach (ValidationStatement validationStatement in validationStatements)
            {
                if (validationStatement.DependantFieldName == "this")
                {
                    if(thisProperty.PropertyType == typeof(bool))
                        dependantFieldsListString += "bp.this,";
                    else
                        dependantFieldsListString += "this,";
                }
                else
                {
                    if (baseType.GetPropertyInfoWithDotNotation(validationStatement.DependantFieldName).PropertyType == typeof(bool))
                        dependantFieldsListString += "bp." + validationStatement.DependantFieldName + ",";
                    else
                        dependantFieldsListString += "p." + validationStatement.DependantFieldName + ",";
                }
            }
            return dependantFieldsListString.TrimEnd(",");
        }

        public string GetClientSideComparisonValues(Type baseType)
        {
            string comparisonValuesListString = string.Empty;
            foreach (ValidationStatement validationStatement in validationStatements)
            {
                if (validationStatement.Operator.ToString().EndsWith("Field"))
                {
                    if (baseType.GetPropertyInfoWithDotNotation(validationStatement.ComparisonValueOrFieldNameOrRegex.ToString()).PropertyType == typeof(bool))
                        comparisonValuesListString += "bp." + validationStatement.ComparisonValueOrFieldNameOrRegex + "^|^";
                    else
                        comparisonValuesListString += "p." + validationStatement.ComparisonValueOrFieldNameOrRegex + "^|^";
                }
                else if (validationStatement.ComparisonValueOrFieldNameOrRegex is bool)
                    comparisonValuesListString += "b." + validationStatement.ComparisonValueOrFieldNameOrRegex.ToString().ToLower() + "^|^"; // Need to use more elaborate divider to avoid chance of conflicting with values
                else
                {
                    //if (validationStatement.ComparisonValueOrFieldNameOrRegex is DateOf)
                    //    comparisonValuesListString += "s." + validationStatement.ComparisonValueOrFieldNameOrRegex + "^|^";
                    //else
                        comparisonValuesListString += "s." + validationStatement.ComparisonValueOrFieldNameOrRegex + "^|^";
                }
                    
            }
            return comparisonValuesListString.TrimEnd("^|^");
        }
        
        public string GetClientSideOperators()
        {
            string operatorsListString = string.Empty;

            foreach (ValidationStatement validationStatement in validationStatements)
            {
                string shortHandOperator = string.Empty;

                switch (validationStatement.Operator)
                {
                    case Operator.GreaterThan:
                    case Operator.GreaterThanField:
                        shortHandOperator = ">"; break;

                    case Operator.GreaterThanOrEqualTo:
                    case Operator.GreaterThanOrEqualToField:
                        shortHandOperator = ">="; break;

                    case Operator.LessThan:
                    case Operator.LessThanField:
                        shortHandOperator = "<"; break;

                    case Operator.LessThanOrEqualTo:
                    case Operator.LessThanOrEqualToField:
                        shortHandOperator = "<="; break;
                        
                    case Operator.NumericallyEqualTo:
                    case Operator.NumericallyEqualToField:
                        shortHandOperator = "="; break;

                    case Operator.NumericallyNotEqualTo:
                    case Operator.NumericallyNotEqualToField:
                        shortHandOperator = "!="; break;

                    case Operator.EqualTo:
                    case Operator.EqualToField:
                        shortHandOperator = "=="; break;

                    case Operator.NotEqualTo:
                    case Operator.NotEqualToField:
                        shortHandOperator = "!=="; break;

                    case Operator.LongerThan:
                    case Operator.LongerThanField:
                        shortHandOperator = "L>"; break;

                    case Operator.LongerOrLengthEqualTo:
                    case Operator.LongerOrLengthEqualToField:
                        shortHandOperator = "L>="; break;

                    case Operator.ShorterThan:
                    case Operator.ShorterThanField:
                        shortHandOperator = "L<"; break;

                    case Operator.ShorterOrLengthEqualTo:
                    case Operator.ShorterOrLengthEqualToField:
                        shortHandOperator = "L<="; break;

                    case Operator.LengthEqualTo:
                    case Operator.LengthEqualToField:
                        shortHandOperator = "L="; break;

                    case Operator.LengthNotEqualTo:
                    case Operator.LengthNotEqualToField:
                        shortHandOperator = "L!="; break;

                    case Operator.MatchesRegularExpression:
                    case Operator.MatchesRegularExpressionField:
                        shortHandOperator = "rgx"; break;

                    case Operator.FailsRegularExpression:
                    case Operator.FailsRegularExpressionField:
                        shortHandOperator = "!rgx"; break;

                    case Operator.Contains:
                    case Operator.ContainsField:
                        shortHandOperator = "ctn"; break;

                    case Operator.DoesntContain:
                    case Operator.DoesntContainField:
                        shortHandOperator = "!ctn"; break;

                    case Operator.MoreRecentThan:
                    case Operator.MoreRecentThanField:
                        shortHandOperator = "D>"; break;

                    case Operator.MoreRecentThanOrEqualTo:
                    case Operator.MoreRecentThanOrEqualToField:
                        shortHandOperator = "D>="; break;

                    case Operator.OlderThan:
                    case Operator.OlderThanField:
                        shortHandOperator = "D<"; break;

                    case Operator.OlderThanOrEqualTo:
                    case Operator.OlderThanOrEqualToField:
                        shortHandOperator = "D<="; break;

                    case Operator.DateEqualTo:
                    case Operator.DateEqualToField:
                        shortHandOperator = "D="; break;

                    case Operator.DateNotEqualTo:
                    case Operator.DateNotEqualToField:
                        shortHandOperator = "D!="; break;
                }
                operatorsListString += shortHandOperator + ",";

            }

            return operatorsListString.TrimEnd(",");
        }

        public string GetClientSideConjuctions(Bracket closingBrackets)
        {
            string conjuctionsListString = string.Empty;

            foreach (AndOr conjuction in conjunctions)
            {
                switch (conjuction)
                {
                    case AndOr.And:
                        conjuctionsListString += "&,";
                        break;
                    case AndOr.And_C:
                        conjuctionsListString += "&(,";
                        break;
                    case AndOr.Ɔ_And:
                        conjuctionsListString += ")&,";
                        break;
                    case AndOr.Ɔ_And_C:
                        conjuctionsListString += ")&(,";
                        break;
                    case AndOr.And_CC:
                        conjuctionsListString += "&((,";
                        break;
                    case AndOr.ƆƆ_And:
                        conjuctionsListString += "))&,";
                        break;
                    case AndOr.ƆƆ_And_C:
                        conjuctionsListString += "))&(,";
                        break;
                    case AndOr.Ɔ_And_CC:
                        conjuctionsListString += ")&((,";
                        break;
                    case AndOr.ƆƆ_And_CC:
                        conjuctionsListString += "))&((,";
                        break;

                    case AndOr.Or:
                        conjuctionsListString += "|,";
                        break;
                    case AndOr.Or_C:
                        conjuctionsListString += "|(,";
                        break;
                    case AndOr.Ɔ_Or:
                        conjuctionsListString += ")|,";
                        break;
                    case AndOr.Ɔ_Or_C:
                        conjuctionsListString += ")|(,";
                        break;
                    case AndOr.Or_CC:
                        conjuctionsListString += "|((,";
                        break;
                    case AndOr.ƆƆ_Or:
                        conjuctionsListString += "))|,";
                        break;
                    case AndOr.Ɔ_Or_CC:
                        conjuctionsListString += ")|((,";
                        break;
                    case AndOr.ƆƆ_Or_C:
                        conjuctionsListString += "))|(,";
                        break;
                    case AndOr.ƆƆ_Or_CC:
                        conjuctionsListString += "))|((,";
                        break;  
                }
            }


            switch (closingBrackets)
            {
                case Bracket.Ɔ:
                    conjuctionsListString += ")";
                    break;
                case Bracket.ƆƆ:
                    conjuctionsListString += "))";
                    break;
                case Bracket.ƆƆƆ:
                    conjuctionsListString += ")))";
                    break;
            }

            return conjuctionsListString.TrimEnd(",");
        }

        public bool DateFormatNeeded
        {
            get
            {
                return validationStatements.Any(x => x.Operator.ToString().Contains("Date") || 
                                                     x.Operator.ToString().Contains("Older") ||
                                                     x.Operator.ToString().Contains("MoreRecent"));
            }
        }

        public string DateFormat 
        {
            get { return validationStatements.First().DateFormat;  }
        }

        public static bool EvaluateExpression(string expression)
        {
            expression = expression.Replace("true", "True")
                                   .Replace("false", "False")
                                   .Replace("&&", " And ")
                                   .Replace("||", " Or ");

            return (bool)((new DataTable()).Compute(expression, ""));
        }
    }
}