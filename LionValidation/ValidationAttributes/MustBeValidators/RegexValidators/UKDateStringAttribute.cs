using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    public class UKDateStringAttribute : MustBeAttribute
    {
        public UKDateStringAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.UKDate)
        { }

        public UKDateStringAttribute(UseStrict useStrict)
            : base(Operator.MatchesRegularExpression, useStrict == UseStrict.True ? RegexHelper.UKDateStrict : RegexHelper.UKDate)
        {}
    }

    public enum UseStrict { True, False }
}