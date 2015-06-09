using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class LengthEqualToAnyAttribute : MustBeAttribute
    {
        public LengthEqualToAnyAttribute(int comparisonValue)
            : base(Operator.LengthEqualTo, comparisonValue)
        {}

        public LengthEqualToAnyAttribute(int comparisonValue1, int comparisonValue2)
            : base(Operator.LengthEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue2)
        { }
        
        public LengthEqualToAnyAttribute(int comparisonValue1, int comparisonValue2, int comparisonValue3)
            : base(Operator.LengthEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue3)
        { }

        public LengthEqualToAnyAttribute(int comparisonValue1, int comparisonValue2, int comparisonValue3, int comparisonValue4)
            : base(Operator.LengthEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue4)
        { }

        public LengthEqualToAnyAttribute(int comparisonValue1, int comparisonValue2, int comparisonValue3, int comparisonValue4, int comparisonValue5)
            : base(Operator.LengthEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue5)
        { }

        public LengthEqualToAnyAttribute(int comparisonValue1, int comparisonValue2, int comparisonValue3, int comparisonValue4, int comparisonValue5, int comparisonValue6)
            : base(Operator.LengthEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue5, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue6)
        { }

        public LengthEqualToAnyAttribute(int comparisonValue1, int comparisonValue2, int comparisonValue3, int comparisonValue4, int comparisonValue5, int comparisonValue6, int comparisonValue7)
            : base(Operator.LengthEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue5, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue6, AndOr.Or,
                   "this", Operator.LengthEqualTo, comparisonValue7)
        { }
    }
}