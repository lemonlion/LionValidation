using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class EqualToAnyAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue)
            : base(Operator.EqualTo, comparisonValue)
        {}

        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue1, object comparisonValue2)
            : base(Operator.EqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue2)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3)
            : base(Operator.EqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue3)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4)
            : base(Operator.EqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue4)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5)
            : base(Operator.EqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue5)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        /// <param name="comparisonValue6">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5, object comparisonValue6)
            : base(Operator.EqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue5, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue6)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        /// <param name="comparisonValue6">A value to compare to</param>
        /// <param name="comparisonValue7">A value to compare to</param>
        public EqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5, object comparisonValue6, object comparisonValue7)
            : base(Operator.EqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue5, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue6, AndOr.Or,
                   "this", Operator.EqualTo, comparisonValue7)
        { }
    }
}