using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is more recent than the date value of a comparison property
    /// </summary>
    public class MoreRecentThanFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is more recent than the date value of a comparison property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a date value to compare to</param>
        public MoreRecentThanFieldAttribute(string comparisonField)
            : base(Operator.MoreRecentThanField, comparisonField)
        {}
    }
}