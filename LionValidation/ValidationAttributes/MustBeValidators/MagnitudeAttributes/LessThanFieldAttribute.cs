using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is less than the numerical value of the specified property
    /// </summary>
    public class LessThanFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is less than the numerical value of the specified property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a numerical value to compare to</param>
        public LessThanFieldAttribute(string comparisonField)
            : base(Operator.LessThanField, comparisonField)
        {}
    }
}