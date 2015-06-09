using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if all the named properties listed are false.
    /// </summary>
    public class RequiredIfAllFalseAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName)
            : base(dependantFieldName, Operator.EqualTo, false)
        {}

        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName1, string dependantFieldName2) 
            : base(dependantFieldName1, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName2, Operator.EqualTo, false)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3)
            : base(dependantFieldName1, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName2, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName3, Operator.EqualTo, false)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4)
            : base(dependantFieldName1, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName2, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName3, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName4, Operator.EqualTo, false)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5)
            : base(dependantFieldName1, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName2, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName3, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName4, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName5, Operator.EqualTo, false)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName6">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5, string dependantFieldName6)
            : base(dependantFieldName1, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName2, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName3, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName4, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName5, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName6, Operator.EqualTo, false)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if all the named properties listed are false.
        /// </summary>
        /// <param name="dependantFieldName1">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName2">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName3">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName4">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName5">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName6">The name of a property to check for an false value</param>
        /// <param name="dependantFieldName7">The name of a property to check for an false value</param>
        public RequiredIfAllFalseAttribute(string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4, string dependantFieldName5, string dependantFieldName6, string dependantFieldName7)
            : base(dependantFieldName1, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName2, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName3, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName4, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName5, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName6, Operator.EqualTo, false, AndOr.And,
                   dependantFieldName7, Operator.EqualTo, false)
        { }
    }
}