using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterOrLengthEqualToFieldAttribute : MustBeAttribute
    {
        public ShorterOrLengthEqualToFieldAttribute(string comparisonField)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField)
        {}
    }
}