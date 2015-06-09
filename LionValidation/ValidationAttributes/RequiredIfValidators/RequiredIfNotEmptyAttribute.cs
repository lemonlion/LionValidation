using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a named property is not empty.
    /// </summary>
    public class RequiredIfNotEmptyAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if a named property is not empty.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an empty value</param>
        public RequiredIfNotEmptyAttribute(string dependantFieldName)
            : base(dependantFieldName, Operator.NotEqualTo, "")
        {}
    }
}