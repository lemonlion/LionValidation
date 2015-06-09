using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LengthEqualToAttribute : MustBeAttribute
    {
        public LengthEqualToAttribute(int comparisonValue)
            : base(Operator.LengthEqualTo, comparisonValue)
        {}
    }
}