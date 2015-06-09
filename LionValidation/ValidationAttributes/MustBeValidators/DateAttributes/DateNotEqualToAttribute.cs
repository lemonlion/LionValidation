using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is not equal to an absolute or relative date
    /// </summary>
    public class DateNotEqualToAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is not equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date (eg. "12 years, 11 months, 6 days ago" or "10 years from now")</param>
        public DateNotEqualToAttribute(string dateOrRelativeDate)
            : base(Operator.DateNotEqualTo, dateOrRelativeDate)
        { }

        /// <summary>
        /// Validates a date is not equal to a relative date
        /// </summary>
        /// <param name="relativeDate">A relative date from now</param>
        public DateNotEqualToAttribute(DateOf relativeDate)
            : base(Operator.DateNotEqualTo, relativeDate)
        { }
    }
}