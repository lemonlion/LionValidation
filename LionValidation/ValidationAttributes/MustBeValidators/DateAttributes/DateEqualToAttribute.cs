using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is equal to an absolute or relative date
    /// </summary>
    public class DateEqualToAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is equal to an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date (eg. "12 years, 11 months, 6 days ago" or "10 years from now")</param>
        public DateEqualToAttribute(string dateOrRelativeDate)
            : base(Operator.DateEqualTo, dateOrRelativeDate)
        { }

        /// <summary>
        /// Validates a date is equal to a relative date
        /// </summary>
        /// <param name="relativeDate">A relative date to compare to</param>
        public DateEqualToAttribute(DateOf relativeDate)
            : base(Operator.DateEqualTo, relativeDate)
        { }
    }
}