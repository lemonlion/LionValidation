﻿using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
    /// </summary>
    public class RequiredIfAllRegexNotMatchAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName)
            : base(dependantFieldName, Operator.FailsRegularExpression, regularExpression)
        {}

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2)
            : base(dependantFieldName1, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName2, Operator.FailsRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3)
            : base(dependantFieldName1, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName2, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName3, Operator.FailsRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4)
            : base(dependantFieldName1, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName2, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName3, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName4, Operator.FailsRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName5">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4,
                                                   string dependantFieldName5)
            : base(dependantFieldName1, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName2, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName3, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName4, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName5, Operator.FailsRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName5">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName6">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4,
                                                   string dependantFieldName5, string dependantFieldName6)
            : base(dependantFieldName1, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName2, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName3, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName4, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName5, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName6, Operator.FailsRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if every named property listed does not match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName5">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName6">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName7">The name of a property to compare to the regular expression to</param>
        public RequiredIfAllRegexNotMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4,
                                                   string dependantFieldName5, string dependantFieldName6, string dependantFieldName7)
            : base(dependantFieldName1, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName2, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName3, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName4, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName5, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName6, Operator.FailsRegularExpression, regularExpression, AndOr.And,
                   dependantFieldName7, Operator.FailsRegularExpression, regularExpression)
        { }
    }
}