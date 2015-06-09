using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a date string represents a date of birth of someone at least 18 years old
    /// </summary>
    public class DobOlderThan18Attribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a date string represents a date of birth of someone at least 18 years old
        /// </summary>
        public DobOlderThan18Attribute()
            : base(Operator.OlderThanOrEqualTo, DateOf.EighteenYearsAgo)
        {}

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field must be at least 18 years old";
        }
    }
}