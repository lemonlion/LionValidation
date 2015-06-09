using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LessThanOrEqualToAttribute : MustBeAttribute
    {
        public LessThanOrEqualToAttribute(int comparisonValue)
            : base(Operator.LessThanOrEqualTo, comparisonValue)
        {}

        public LessThanOrEqualToAttribute(double comparisonValue)
            : base(Operator.LessThanOrEqualTo, comparisonValue)
        { }
    }
}