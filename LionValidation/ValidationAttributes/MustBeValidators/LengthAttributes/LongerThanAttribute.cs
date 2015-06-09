using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerThanAttribute : MustBeAttribute
    {
        public LongerThanAttribute(int comparisonValue)
            : base(Operator.LongerThan, comparisonValue)
        {}
    }
}