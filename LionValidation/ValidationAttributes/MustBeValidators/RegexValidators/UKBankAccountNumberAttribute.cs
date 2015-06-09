using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    public class UKBankAccountNumber : MustBeAttribute
    {
        public UKBankAccountNumber()
            : base(Operator.MatchesRegularExpression, RegexHelper.UKBankAccountNumber)
        {}
    }
}