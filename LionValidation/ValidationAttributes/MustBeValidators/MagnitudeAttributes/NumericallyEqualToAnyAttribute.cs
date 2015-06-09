using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
    /// </summary>
    public class NumericallyEqualToAnyAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue)
            : base(Operator.NumericallyEqualTo, comparisonValue)
        {}

        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue1, object comparisonValue2)
            : base(Operator.NumericallyEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue2)
        { }

        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3)
            : base(Operator.NumericallyEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue3)
        { }

        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4)
            : base(Operator.NumericallyEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue4)
        { }

        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5)
            : base(Operator.NumericallyEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue5)
        { }

        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        /// <param name="comparisonValue6">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5, object comparisonValue6)
            : base(Operator.NumericallyEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue5, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue6)
        { }

        /// <summary>
        /// Validates that the numerical value is equal to the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        /// <param name="comparisonValue6">A value to compare to</param>
        /// <param name="comparisonValue7">A value to compare to</param>
        public NumericallyEqualToAnyAttribute(object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5, object comparisonValue6, object comparisonValue7)
            : base(Operator.NumericallyEqualTo, comparisonValue1, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue2, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue3, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue4, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue5, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue6, AndOr.Or,
                   "this", Operator.NumericallyEqualTo, comparisonValue7)
        { }
    }
}