using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is greater than a specified numerical value
    /// </summary>
    public class GreaterThanAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is greater than a specified integer value
        /// </summary>
        /// <param name="comparisonValue">An integer value to compare to</param>
        public GreaterThanAttribute(int comparisonValue)
            : base(Operator.GreaterThan, comparisonValue)
        {}

        /// <summary>
        /// Validates that a property's numerical value is greater than a specified integer value
        /// </summary>
        /// <param name="comparisonValue">A floating point value to compare to</param>
        public GreaterThanAttribute(double comparisonValue)
            : base(Operator.GreaterThan, comparisonValue)
        { }
    }
}