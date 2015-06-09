using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerThanAllFieldsAttribute : MustBeAttribute
    {
        public LongerThanAllFieldsAttribute(string comparisonField)
            : base(Operator.LongerThanField, comparisonField)
        {}

        public LongerThanAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.LongerThanField, comparisonField1, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField2)
        { }

        public LongerThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.LongerThanField, comparisonField1, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField3)
        { }

        public LongerThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.LongerThanField, comparisonField1, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField4)
        { }

        public LongerThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.LongerThanField, comparisonField1, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField4, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField5)
        { }

        public LongerThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.LongerThanField, comparisonField1, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField4, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField5, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField6)
        { }

        public LongerThanAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.LongerThanField, comparisonField1, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField4, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField5, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField6, AndOr.And,
                   "this", Operator.LongerThanField, comparisonField7)
        { }
    }
}