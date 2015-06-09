using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the value is equal to the value of any of the properties listed
    /// </summary>
    public class EqualToAnyFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField)
            : base(Operator.EqualToField, comparisonField)
        {}

        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property to compare to</param>
        /// <param name="comparisonField2">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField1, string comparisonField2)
            : base(Operator.EqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField2)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property to compare to</param>
        /// <param name="comparisonField2">The name of a property to compare to</param>
        /// <param name="comparisonField3">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3)
            : base(Operator.EqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField3)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property to compare to</param>
        /// <param name="comparisonField2">The name of a property to compare to</param>
        /// <param name="comparisonField3">The name of a property to compare to</param>
        /// <param name="comparisonField4">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4)
            : base(Operator.EqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField4)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property to compare to</param>
        /// <param name="comparisonField2">The name of a property to compare to</param>
        /// <param name="comparisonField3">The name of a property to compare to</param>
        /// <param name="comparisonField4">The name of a property to compare to</param>
        /// <param name="comparisonField5">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5)
            : base(Operator.EqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField5)
        { }

        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property to compare to</param>
        /// <param name="comparisonField2">The name of a property to compare to</param>
        /// <param name="comparisonField3">The name of a property to compare to</param>
        /// <param name="comparisonField4">The name of a property to compare to</param>
        /// <param name="comparisonField5">The name of a property to compare to</param>
        /// <param name="comparisonField6">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6)
            : base(Operator.EqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField6)
        { }
        
        /// <summary>
        /// Validates that the value is equal to the value of any of the properties listed
        /// </summary>
        /// <param name="comparisonField1">The name of a property to compare to</param>
        /// <param name="comparisonField2">The name of a property to compare to</param>
        /// <param name="comparisonField3">The name of a property to compare to</param>
        /// <param name="comparisonField4">The name of a property to compare to</param>
        /// <param name="comparisonField5">The name of a property to compare to</param>
        /// <param name="comparisonField6">The name of a property to compare to</param>
        /// <param name="comparisonField7">The name of a property to compare to</param>
        public EqualToAnyFieldAttribute(string comparisonField1, string comparisonField2, string comparisonField3, string comparisonField4, string comparisonField5, string comparisonField6, string comparisonField7)
            : base(Operator.EqualToField, comparisonField1, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField2, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField3, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField4, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField5, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField6, AndOr.Or,
                   "this", Operator.EqualToField, comparisonField7)
        { }
    }
}