using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LongerThanAnyFieldAttribute : MustBeAttribute
    {
        public LongerThanAnyFieldAttribute(string comparisonField)
            : base(Operator.LongerThanField, comparisonField)
        {}

        public LongerThanAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.LongerThanField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField2)
        { }

        public LongerThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.LongerThanField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField3)
        { }

        public LongerThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.LongerThanField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField4)
        { }

        public LongerThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.LongerThanField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField4, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField5)
        { }

        public LongerThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.LongerThanField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField4, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField5, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField6)
        { }

        public LongerThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.LongerThanField, comparisonField1, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField2, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField3, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField4, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField5, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField6, AndOr.Or,
                   "this", Operator.LongerThanField, comparisonField7)
        { }
    }
}