using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is more recent than or equal to the date value of a comparison property
    /// </summary>
    public class MoreRecentThanOrEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is more recent than the date value of a comparison property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a date value to compare to</param>
        public MoreRecentThanOrEqualToFieldAttribute(string comparisonField)
            : base(Operator.MoreRecentThanOrEqualToField, comparisonField)
        { }
    }
}