using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is equal to at least one of the date values listed
    /// </summary>
    public class DateEqualToAnyAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate)
            : base(Operator.DateEqualTo, dateOrRelativeDate)
        {}

        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2)
            : base(Operator.DateEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate2)
        { }

        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3)
            : base(Operator.DateEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate3)
        { }

        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4)
            : base(Operator.DateEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate4)
        { }

        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate5">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4, object dateOrRelativeDate5)
            : base(Operator.DateEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate4, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate5)
        { }

        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate5">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate6">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4, object dateOrRelativeDate5, object dateOrRelativeDate6)
            : base(Operator.DateEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate4, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate5, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate6)
        { }

        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate5">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate6">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate7">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4, object dateOrRelativeDate5, object dateOrRelativeDate6, object dateOrRelativeDate7)
            : base(Operator.DateEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate4, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate5, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate6, AndOr.Or,
                   "this", Operator.DateEqualTo, dateOrRelativeDate7)
        { }
    }
}