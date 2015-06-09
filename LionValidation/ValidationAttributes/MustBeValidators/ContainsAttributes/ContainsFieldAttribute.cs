using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property contains the substring value of the given property
    /// </summary>
    public class ContainsFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property contains the substring value of the given property
        /// </summary>
        /// <param name="comparisonField">The property name of the required substring</param>
        public ContainsFieldAttribute(string comparisonField)
            : base(Operator.ContainsField, comparisonField)
        {}
    }
}