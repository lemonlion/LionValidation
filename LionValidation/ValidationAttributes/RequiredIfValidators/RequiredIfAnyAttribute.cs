using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
    /// </summary>
    public class RequiredIfAnyAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1, object comparisonValue2)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue2)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1, object comparisonValue2, object comparisonValue3)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue2, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue3)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue2, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue3, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue4)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue2, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue3, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue4, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue5)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        /// <param name="comparisonValue6">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5, object comparisonValue6)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue2, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue3, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue4, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue5, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue6)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if a specified property is equal to at least one of the values listed
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to compare to</param>
        /// <param name="comparisonValue1">A value to compare to</param>
        /// <param name="comparisonValue2">A value to compare to</param>
        /// <param name="comparisonValue3">A value to compare to</param>
        /// <param name="comparisonValue4">A value to compare to</param>
        /// <param name="comparisonValue5">A value to compare to</param>
        /// <param name="comparisonValue6">A value to compare to</param>
        /// <param name="comparisonValue7">A value to compare to</param>
        public RequiredIfAnyAttribute(string dependantFieldName, object comparisonValue1, object comparisonValue2, object comparisonValue3, object comparisonValue4, object comparisonValue5, object comparisonValue6, object comparisonValue7)
            : base(dependantFieldName, Operator.EqualTo, comparisonValue1, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue2, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue3, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue4, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue5, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue6, AndOr.Or,
                   dependantFieldName, Operator.EqualTo, comparisonValue7)
        { }
    }
}