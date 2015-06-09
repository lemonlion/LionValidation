using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a date string represents a date of birth of someone at least 16 years old
    /// </summary>
    public class DobOlderThan16Attribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a date string represents a date of birth of someone at least 16 years old
        /// </summary>
        public DobOlderThan16Attribute()
            : base(Operator.OlderThanOrEqualTo, DateOf.SixteenYearsAgo)
        {}

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field must be at least 16 years old";
        }
    }
}