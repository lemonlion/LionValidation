using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if any of the named properties listed are empty.
    /// </summary>
    public class RequiredIfAnyEmptyAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName)
            : base(dependantFieldName, Operator.EqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName1, string dependantFieldName2)
            : base(dependantFieldName1, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName2, Operator.EqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3)
            : base(dependantFieldName1, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName2, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName3, Operator.EqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4)
            : base(dependantFieldName1, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName2, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName3, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName4, Operator.EqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5)
            : base(dependantFieldName1, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName2, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName3, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName4, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName5, Operator.EqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName6">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5, string dependantFieldName6)
            : base(dependantFieldName1, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName2, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName3, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName4, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName5, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName6, Operator.EqualTo, "")
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed are empty.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName6">The name of a property to check for an empty value</param>
        /// <param name="dependantFieldName7">The name of a property to check for an empty value</param>
        public RequiredIfAnyEmptyAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5, string dependantFieldName6, string dependantFieldName7)
            : base(dependantFieldName1, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName2, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName3, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName4, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName5, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName6, Operator.EqualTo, "", AndOr.Or,
                   dependantFieldName7, Operator.EqualTo, "")
        { }
    }
}