using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerOrLengthEqualToAnyFieldAttribute : MustBeAttribute
    {
        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField)
            : base(Operator.LongerOrLengthEqualToField, comparisonField)
        {}

        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2)
        { }

        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3)
        { }

        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4)
        { }

        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField5)
        { }

        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField6)
        { }

        public LongerOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.LongerOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField6, AndOr.Or,
                   "this", Operator.LongerOrLengthEqualToField, comparisonField7)
        { }
    }
}