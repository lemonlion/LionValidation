using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerOrLengthEqualToFieldAttribute : MustBeAttribute
    {
        public LongerOrLengthEqualToFieldAttribute(string comparisonField)
            : base(Operator.LongerOrLengthEqualToField, comparisonField)
        {}
    }
}