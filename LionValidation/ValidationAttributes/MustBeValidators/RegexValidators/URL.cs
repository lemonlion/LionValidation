using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    public class URLAttribute : MustBeAttribute
    {
        public URLAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.URL)
        {}
    }
}