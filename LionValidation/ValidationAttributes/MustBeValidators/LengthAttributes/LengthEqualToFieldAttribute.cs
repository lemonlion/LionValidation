using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LengthEqualToFieldAttribute : MustBeAttribute
    {
        public LengthEqualToFieldAttribute(string comparisonField)
            : base(Operator.LengthEqualToField, comparisonField)
        {}
    }
}