using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterThanAllFieldsAttribute : MustBeAttribute
    {
        public ShorterThanAllFieldsAttribute(string comparisonField)
            : base(Operator.ShorterThanField, comparisonField)
        {}

        public ShorterThanAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField2)
        { }

        public ShorterThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField3)
        { }

        public ShorterThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField4)
        { }

        public ShorterThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField4, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField5)
        { }

        public ShorterThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField4, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField5, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField6)
        { }

        public ShorterThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField4, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField5, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField6, AndOr.And,
                   "this", Operator.ShorterThanField, comparisonField7)
        { }
    }
}