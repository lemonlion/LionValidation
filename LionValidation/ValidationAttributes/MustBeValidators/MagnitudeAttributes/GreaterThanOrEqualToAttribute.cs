using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is greater than or equal to a specified numerical value
    /// </summary>
    public class GreaterThanOrEqualToAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to a specified integer value
        /// </summary>
        /// <param name="comparisonValue">An integer value to compare to</param>
        public GreaterThanOrEqualToAttribute(int comparisonValue)
            : base(Operator.GreaterThanOrEqualTo, comparisonValue)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to a specified integer value
        /// </summary>
        /// <param name="comparisonValue">A floating point value to compare to</param>
        public GreaterThanOrEqualToAttribute(double comparisonValue)
            : base(Operator.GreaterThanOrEqualTo, comparisonValue)
        { }
    }
}