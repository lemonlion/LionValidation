using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is less than or equal to the numerical value of the specified property
    /// </summary>
    public class LessThanOrEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of the specified property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a numerical value to compare to</param>
        public LessThanOrEqualToFieldAttribute(string comparisonField)
            : base(Operator.LessThanOrEqualToField, comparisonField)
        {}
    }
}