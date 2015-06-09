using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
    /// </summary>
    public class RequiredIfAnyRegexMatchAttribute : RequiredIfAttribute
    {
        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName)
            : base(dependantFieldName, Operator.MatchesRegularExpression, regularExpression)
        {}

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2)
            : base(dependantFieldName1, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName2, Operator.MatchesRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3)
            : base(dependantFieldName1, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName2, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName3, Operator.MatchesRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4)
            : base(dependantFieldName1, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName2, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName3, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName4, Operator.MatchesRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName5">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4,
                                                string dependantFieldName5)
            : base(dependantFieldName1, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName2, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName3, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName4, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName5, Operator.MatchesRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName5">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName6">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4,
                                                string dependantFieldName5, string dependantFieldName6)
            : base(dependantFieldName1, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName2, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName3, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName4, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName5, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName6, Operator.MatchesRegularExpression, regularExpression)
        { }

        /// <summary>
        /// Validates the property isn't null or empty if any of the named properties listed match the regular expression provided.
        /// </summary>
        /// <param name="regularExpression">A regular expression</param>
        /// <param name="dependantFieldName1">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName2">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName3">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName4">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName5">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName6">The name of a property to compare to the regular expression to</param>
        /// <param name="dependantFieldName7">The name of a property to compare to the regular expression to</param>
        public RequiredIfAnyRegexMatchAttribute(string regularExpression, string dependantFieldName1, string dependantFieldName2, string dependantFieldName3, string dependantFieldName4,
                                                string dependantFieldName5, string dependantFieldName6, string dependantFieldName7)
            : base(dependantFieldName1, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName2, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName3, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName4, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName5, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName6, Operator.MatchesRegularExpression, regularExpression, AndOr.Or,
                   dependantFieldName7, Operator.MatchesRegularExpression, regularExpression)
        { }
    }
}