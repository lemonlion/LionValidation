using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerOrLengthEqualToAttribute : MustBeAttribute
    {
        public LongerOrLengthEqualToAttribute(int comparisonValue)
            : base(Operator.LongerOrLengthEqualTo, comparisonValue)
        {}
    }
}