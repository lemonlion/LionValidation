using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is greater than the numerical value of the specified property
    /// </summary>
    public class GreaterThanFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of the specified property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a numerical value to compare to</param>
        public GreaterThanFieldAttribute(string comparisonField)
            : base(Operator.GreaterThanField, comparisonField)
        {}
    }
}