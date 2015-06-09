using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
    /// </summary>
    public class DateNotEqualToAnyAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate)
        {}

        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate2)
        { }

        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate3)
        { }

        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate4)
        { }

        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate5">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4, object dateOrRelativeDate5)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate4, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate5)
        { }

        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate5">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate6">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4, object dateOrRelativeDate5, object dateOrRelativeDate6)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate4, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate5, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate6)
        { }

        /// <summary>
        /// Validates a date is not equal to the all the date values listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateOrRelativeDate1">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate2">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate3">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate4">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate5">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate6">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        /// <param name="dateOrRelativeDate7">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date string (eg. "12 years, 11 months, 6 days ago" or "10 years from now"), or a DateOf Enumeration (eg. DateOf.ThreeWeeksAgo) to compare to.</param>
        public DateNotEqualToAnyAttribute(object dateOrRelativeDate1, object dateOrRelativeDate2, object dateOrRelativeDate3, object dateOrRelativeDate4, object dateOrRelativeDate5, object dateOrRelativeDate6, object dateOrRelativeDate7)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate1, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate2, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate3, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate4, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate5, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate6, AndOr.Or,
                   "this", Operator.DateNotEqualTo, dateOrRelativeDate7)
        { }
    }
}