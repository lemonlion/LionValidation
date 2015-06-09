using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property doesn't contain the substring value of the given property
    /// </summary>
    public class DoesntContainFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property doesn't contain the substring value of the given property
        /// </summary>
        /// <param name="comparisonField">The property name of the required substring</param>
        public DoesntContainFieldAttribute(string comparisonField)
            : base(Operator.DoesntContainField, comparisonField)
        {}
    }
}