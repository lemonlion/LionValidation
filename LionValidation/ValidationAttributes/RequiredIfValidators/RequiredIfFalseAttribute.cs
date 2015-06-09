using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a named property is false.
    /// </summary>
    public class RequiredIfFalseAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if a named property is false.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an false value</param>
        public RequiredIfFalseAttribute(string dependantFieldName)
            : base(dependantFieldName, Operator.EqualTo, false)
        {}
    }
}