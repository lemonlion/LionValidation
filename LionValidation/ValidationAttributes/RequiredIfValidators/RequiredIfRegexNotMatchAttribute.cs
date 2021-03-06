﻿using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if a property doesn't match the regular expression provided.
    /// </summary>
    public class RequiredIfRegexNotMatchAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if a property doesn't match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName">The name of a property to compare to the regular expression to</param>
        public RequiredIfRegexNotMatchAttribute(string regularExpression, string dependantFieldName)
            : base(dependantFieldName, Operator.FailsRegularExpression, regularExpression)
        {}
    }
}