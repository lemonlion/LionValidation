using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LengthEqualToAnyFieldAttribute : MustBeAttribute
    {
        public LengthEqualToAnyFieldAttribute(string comparisonField)
            : base(Operator.LengthEqualToField, comparisonField)
        {}

        public LengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.LengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField2)
        { }
        
        public LengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.LengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField3)
        { }

        public LengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.LengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField4)
        { }

        public LengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.LengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField5)
        { }

        public LengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.LengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField6)
        { }

        public LengthEqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.LengthEqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField6, AndOr.Or,
                   "this", Operator.LengthEqualToField, comparisonField7)
        { }
    }
}