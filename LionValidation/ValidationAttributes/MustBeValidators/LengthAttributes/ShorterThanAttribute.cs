using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterThanAttribute : MustBeAttribute
    {
        public ShorterThanAttribute(int comparisonValue)
            : base(Operator.ShorterThan, comparisonValue)
        {}
    }
}