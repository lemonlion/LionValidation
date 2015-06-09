using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is not equal to the numerical value of the specified property
    /// </summary>
    public class NumericallyNotEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is not equal to the numerical value of the specified property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a numerical value to compare to</param>
        public NumericallyNotEqualToFieldAttribute(string comparisonField)
            : base(Operator.NumericallyNotEqualToField, comparisonField)
        {}
    }
}