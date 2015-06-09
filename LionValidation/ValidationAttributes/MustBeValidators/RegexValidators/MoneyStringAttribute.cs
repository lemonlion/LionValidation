using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property's string value conforms to a currency format eg. 3.12
    /// </summary>
    public class MoneyStringAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property's string value conforms to a currency format eg 3.12.  Disallows commas eg. 3,123.12 is not valid
        /// </summary>
        public MoneyStringAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.MoneyValueNoCommas)
        {}

        /// <summary>
        /// Validates that the property's string value conforms to a currency format eg 3.12.
        /// </summary>
        /// <param name="commas">An indicator whether or not commas are allowed</param>
        public MoneyStringAttribute(Commas commas)
            : base(Operator.MatchesRegularExpression, commas == Commas.Allow ? RegexHelper.MoneyValueAllowCommas : RegexHelper.MoneyValueNoCommas)
        { }
    }

    public enum Commas
    {
        Allow,
        Disallow
    }
}