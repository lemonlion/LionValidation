using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property is equal to the string value of the given value
    /// </summary>
    public class EqualToAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property is equal to string value of the given value
        /// </summary>
        /// <param name="comparisonValue">The name of the property to compare to</param>
        public EqualToAttribute(object comparisonValue)
            : base(Operator.EqualTo, comparisonValue)
        {}
    }
}