using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    public class UKPostCodeAttribute : MustBeAttribute
    {
        public UKPostCodeAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.UKPostCode)
        {}
    }
}