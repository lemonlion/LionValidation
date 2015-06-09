using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterOrLengthEqualToAllFieldsAttribute : MustBeAttribute
    {
        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField)
        {}

        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2)
        { }

        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3)
        { }

        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4)
        { }

        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField5)
        { }

        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField6)
        { }

        public ShorterOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField6, AndOr.And,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField7)
        { }
    }
}