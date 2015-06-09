using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
    /// </summary>
    public class DoesntContainAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField)
            : base(Operator.DoesntContainField, comparisonField)
        {}
        
        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.DoesntContainField, comparisonField1, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField2)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.DoesntContainField, comparisonField1, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField2, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField3)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.DoesntContainField, comparisonField1, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField2, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField3, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField4)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField5">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.DoesntContainField, comparisonField1, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField2, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField3, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField4, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField5)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField5">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField6">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.DoesntContainField, comparisonField1, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField2, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField3, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField4, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField5, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField6)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substring values of the properties listed.  If one or more of the substrings is contained, validation fails.
        /// </summary>
        /// <param name="comparisonField1">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField2">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField3">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField4">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField5">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField6">The name of the property which holds a substring value that must be contained within</param>
        /// <param name="comparisonField7">The name of the property which holds a substring value that must be contained within</param>
        public DoesntContainAllFieldsAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.DoesntContainField, comparisonField1, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField2, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField3, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField4, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField5, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField6, AndOr.And,
                   "this", Operator.DoesntContainField, comparisonField7)
        { }
    }
}