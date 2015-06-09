using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is older than or equal to the date value of a comparison property
    /// </summary>
    public class OlderThanOrEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is older than the date value of a comparison property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a date value to compare to</param>
        public OlderThanOrEqualToFieldAttribute(string comparisonField)
            : base(Operator.OlderThanOrEqualToField, comparisonField)
        { }
    }
}