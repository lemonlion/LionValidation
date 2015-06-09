using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if every named property listed is not empty.
    /// </summary>
    public class RequiredIfAllNotEmptyAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName)
            : base(dependantFieldName, Operator.NotEqualTo, "")
        {}

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName1, string dependantFieldName2)
            : base(dependantFieldName1, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName2, Operator.NotEqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3)
            : base(dependantFieldName1, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName2, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName3, Operator.NotEqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4)
            : base(dependantFieldName1, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName2, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName3, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName4, Operator.NotEqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5)
            : base(dependantFieldName1, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName2, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName3, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName4, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName5, Operator.NotEqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName6">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5, string dependantFieldName6)
            : base(dependantFieldName1, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName2, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName3, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName4, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName5, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName6, Operator.NotEqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed is not empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName6">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName7">The name of a property to check for an empty value</param>
        public RequiredIfAllNotEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5, string dependantFieldName6, string dependantFieldName7)
            : base(dependantFieldName1, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName2, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName3, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName4, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName5, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName6, Operator.NotEqualTo, "", AndOr.And,
                   dependantFieldName7, Operator.NotEqualTo, "")
        { }
    }
}