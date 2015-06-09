using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerThanFieldAttribute : MustBeAttribute
    {
        public LongerThanFieldAttribute(string comparisonField)
            : base(Operator.LongerThanField, comparisonField)
        {}
    }
}