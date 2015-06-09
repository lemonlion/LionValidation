using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is equal to a specified numerical value
    /// </summary>
    public class NumericallyEqualToAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is equal to a specified integer value
        /// </summary>
        /// <param name="comparisonValue">An integer value to compare to</param>
        public NumericallyEqualToAttribute(int comparisonValue)
            : base(Operator.NumericallyEqualTo, comparisonValue)
        {}

        /// <summary>
        /// Validates that a property's numerical value is equal to a specified integer value
        /// </summary>
        /// <param name="comparisonValue">A floating point value to compare to</param>
        public NumericallyEqualToAttribute(double comparisonValue)
            : base(Operator.NumericallyEqualTo, comparisonValue)
        { }
    }
}