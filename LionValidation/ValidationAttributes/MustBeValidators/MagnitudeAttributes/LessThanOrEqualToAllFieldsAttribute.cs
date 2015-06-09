using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
    /// </summary>
    public class LessThanOrEqualToAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField)
            : base(Operator.LessThanOrEqualToField, comparisonField)
        { }

        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.LessThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField2)
        { }

        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.LessThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField3)
        { }

        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.LessThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField4)
        { }

        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.LessThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField5)
        { }

        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField6">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.LessThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField6)
        { }

        /// <summary>
        /// Validates that a property's numerical value is less than or equal to the numerical value of all the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField2">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField3">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField4">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField5">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField6">The name of a property that contains a numerical value to compare to</param>
        /// <param name="comparisonField7">The name of a property that contains a numerical value to compare to</param>
        public LessThanOrEqualToAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.LessThanOrEqualToField, comparisonField1, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField2, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField3, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField4, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField5, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField6, AndOr.And,
                   "this", Operator.LessThanOrEqualToField, comparisonField7)
        { }
    }
}