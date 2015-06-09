using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{   
    /// <summary>
    /// Validates a date is older than an absolute or relative date
    /// </summary>
    public class OlderThanAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is older than an absolute or relative date
        /// </summary>
        /// <param name="dateOrRelativeDate">An absolute date in the specified date format (eg. "01/01/2000"), or a relative date (eg. "12 years, 11 months, 6 days ago" or "10 years from now")</param>
        public OlderThanAttribute(string dateOrRelativeDate)
            : base(Operator.OlderThan, dateOrRelativeDate)
        {}

        /// <summary>
        /// Validates a date is older than a relative date
        /// </summary>
        /// <param name="relativeDate">A relative date to compare to</param>
        public OlderThanAttribute(DateOf relativeDate)
            : base(Operator.OlderThan, relativeDate)
        { }
    }
}