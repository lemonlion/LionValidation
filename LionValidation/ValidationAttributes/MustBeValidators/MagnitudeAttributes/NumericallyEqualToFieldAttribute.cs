using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is equal to the numerical value of the specified property
    /// </summary>
    public class NumericallyEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is equal to the numerical value of the specified property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a numerical value to compare to</param>
        public NumericallyEqualToFieldAttribute(string comparisonField)
            : base(Operator.NumericallyEqualToField, comparisonField)
        {}
    }
}