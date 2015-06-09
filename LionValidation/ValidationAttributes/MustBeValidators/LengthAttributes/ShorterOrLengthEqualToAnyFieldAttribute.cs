using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterOrLengthEqualToAnyFieldAttribute : MustBeAttribute
    {
        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField)
        {}

        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2)
        { }

        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3)
        { }

        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4)
        { }

        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField5)
        { }

        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField6)
        { }

        public ShorterOrLengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.ShorterOrLengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField6, AndOr.Or,
                   "this", Operator.ShorterOrLengthEqualToField, comparisonField7)
        { }
    }
}