using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
    /// </summary>
    public class GreaterThanOrEqualToAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField)
            : base(Operator.GreaterThanOrEqualToField, comparisonField)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.GreaterThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField2)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.GreaterThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField3)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.GreaterThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField4)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.GreaterThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField5)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField6">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.GreaterThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField6)
        { }

        /// <summary>
        /// Validates that a property's numerical value is greater than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField6">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField7">The name of a property that contains a numerical value to compare to</param>
        public GreaterThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.GreaterThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField6, AndOr.And,
                   "this", Operator.GreaterThanOrEqualToField, comparisonField7)
        { }
    }
}