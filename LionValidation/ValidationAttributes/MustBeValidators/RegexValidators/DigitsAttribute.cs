using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property's value consists of only numerical digits
    /// </summary>
    public class DigitsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property's value consists of only numerical digits
        /// </summary>
        public DigitsAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.Digits)
        {}
    }
}