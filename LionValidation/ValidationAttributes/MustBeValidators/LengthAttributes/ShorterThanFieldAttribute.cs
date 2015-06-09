using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterThanFieldAttribute : MustBeAttribute
    {
        public ShorterThanFieldAttribute(string comparisonField)
            : base(Operator.ShorterThanField, comparisonField)
        {}
    }
}