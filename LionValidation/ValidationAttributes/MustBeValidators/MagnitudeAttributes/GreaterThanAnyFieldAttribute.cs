using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
    /// </summary>
    public class GreaterThanAnyFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField)
            : base(Operator.GreaterThanField, comparisonField)
        {}

        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.GreaterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField2)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.GreaterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField3)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.GreaterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField4)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.GreaterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField4, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField5)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField6">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.GreaterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField4, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField5, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField6)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than the numerical value of at least one of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField6">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField7">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.GreaterThanField, comparisonField1, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField2, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField3, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField4, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField5, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField6, AndOr.Or,
                   "this", Operator.GreaterThanField, comparisonField7)
        { }
    }
}