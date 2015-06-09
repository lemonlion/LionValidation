using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterOrLengthEqualToAttribute : MustBeAttribute
    {
        public ShorterOrLengthEqualToAttribute(int comparisonValue)
            : base(Operator.ShorterOrLengthEqualTo, comparisonValue)
        {}
    }
}