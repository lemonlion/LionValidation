using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a named property is true.
    /// </summary>
    public class RequiredIfTrueAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if a named property is true.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an true value</param>
        public RequiredIfTrueAttribute(string dependantFieldName) : base(dependantFieldName, Operator.EqualTo, true)
        {}
    }
}