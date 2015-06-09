using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class ShorterThanAnyFieldAttribute : MustBeAttribute
    {
        public ShorterThanAnyFieldAttribute(string comparisonField)
            : base(Operator.ShorterThanField, comparisonField)
        {}

        public ShorterThanAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField2)
        { }

        public ShorterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField3)
        { }

        public ShorterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField4)
        { }

        public ShorterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField4, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField5)
        { }

        public ShorterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField4, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField5, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField6)
        { }

        public ShorterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.ShorterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField4, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField5, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField6, AndOr.Or,
                   "this", Operator.ShorterThanField, comparisonField7)
        { }
    }
}