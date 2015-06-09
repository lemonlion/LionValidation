using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a named property is empty.
    /// </summary>
    public class RequiredIfEmptyAttribute : RequiredIfAttribute
    {   
        /// <summary>
        /// Validates the property isn't null or empty if a named property is empty.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an empty value</param>
        public RequiredIfEmptyAttribute(string dependantFieldName)
            : base(dependantFieldName, Operator.EqualTo, "")
        {}
    }
}