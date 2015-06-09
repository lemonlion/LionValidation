using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is less than a specified numerical value
    /// </summary>
    public class LessThanAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is less than a specified integer value
        /// </summary>
        /// <param name="comparisonValue">An integer value to compare to</param>
        public LessThanAttribute(int comparisonValue)
            : base(Operator.LessThan, comparisonValue)
        {}

        /// <summary>
        /// Validates that a property's numerical value is less than a specified integer value
        /// </summary>
        /// <param name="comparisonValue">A floating point value to compare to</param>
        public LessThanAttribute(double comparisonValue)
            : base(Operator.LessThan, comparisonValue)
        { }
    }
}