using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the value is equal to the value of another property
    /// </summary>
    public class EqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the value is equal to the value of another property
        /// </summary>
        /// <param name="comparisonField">The name of the property to compare to</param>
        public EqualToFieldAttribute(string comparisonField)
            : base(Operator.EqualToField, comparisonField)
        {}
    }
}