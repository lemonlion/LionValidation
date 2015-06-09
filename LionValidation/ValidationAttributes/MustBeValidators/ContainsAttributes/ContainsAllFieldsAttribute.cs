using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property contains all the substring values of the properties listed
    /// </summary>
    public class ContainsAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField)
            : base(Operator.ContainsField, comparisonField)
        {}
        
        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.ContainsField, comparisonField1, AndOr.And,
                   "this", Operator.ContainsField, comparisonField2)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.ContainsField, comparisonField1, AndOr.And,
                   "this", Operator.ContainsField, comparisonField2, AndOr.And,
                   "this", Operator.ContainsField, comparisonField3)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.ContainsField, comparisonField1, AndOr.And,
                   "this", Operator.ContainsField, comparisonField2, AndOr.And,
                   "this", Operator.ContainsField, comparisonField3, AndOr.And,
                   "this", Operator.ContainsField, comparisonField4)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField5">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.ContainsField, comparisonField1, AndOr.And,
                   "this", Operator.ContainsField, comparisonField2, AndOr.And,
                   "this", Operator.ContainsField, comparisonField3, AndOr.And,
                   "this", Operator.ContainsField, comparisonField4, AndOr.And,
                   "this", Operator.ContainsField, comparisonField5)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField5">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField6">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.ContainsField, comparisonField1, AndOr.And,
                   "this", Operator.ContainsField, comparisonField2, AndOr.And,
                   "this", Operator.ContainsField, comparisonField3, AndOr.And,
                   "this", Operator.ContainsField, comparisonField4, AndOr.And,
                   "this", Operator.ContainsField, comparisonField5, AndOr.And,
                   "this", Operator.ContainsField, comparisonField6)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substring values of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField5">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField6">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField7">The name of the property which holds a substring value that must be contained within</param>
        public ContainsAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.ContainsField, comparisonField1, AndOr.And,
                   "this", Operator.ContainsField, comparisonField2, AndOr.And,
                   "this", Operator.ContainsField, comparisonField3, AndOr.And,
                   "this", Operator.ContainsField, comparisonField4, AndOr.And,
                   "this", Operator.ContainsField, comparisonField5, AndOr.And,
                   "this", Operator.ContainsField, comparisonField6, AndOr.And,
                   "this", Operator.ContainsField, comparisonField7)
        { }
    }
}