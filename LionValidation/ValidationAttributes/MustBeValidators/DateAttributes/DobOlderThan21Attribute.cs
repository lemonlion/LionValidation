using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a date string represents a date of birth of someone at least 21 years old
    /// </summary>
    public class DobOlderThan21Attribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a date string represents a date of birth of someone at least 21 years old
        /// </summary>
        public DobOlderThan21Attribute()
            : base(Operator.OlderThanOrEqualTo, DateOf.TwentyOneYearsAgo)
        {}

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field must be at least 21 years old";
        }
    }
}