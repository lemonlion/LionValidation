using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerOrLengthEqualToAllFieldsAttribute : MustBeAttribute
    {
        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField)
            : base(Operator.LongerOrLengthEqualToField, comparisonField)
        {}

        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2)
        { }

        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3)
        { }

        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4)
        { }

        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField5)
        { }

        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField6)
        { }

        public LongerOrLengthEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField6, AndOr.And,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField7)
        { }
    }
}