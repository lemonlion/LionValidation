using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property contains all the substrings listed
    /// </summary>
    public class ContainsAllAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring)
            : base(Operator.Contains, requiredSubstring)
        {}

        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring1, string requiredSubstring2)
            : base(Operator.Contains, requiredSubstring1, AndOr.And,
                   "this", Operator.Contains, requiredSubstring2)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3)
            : base(Operator.Contains, requiredSubstring1, AndOr.And,
                   "this", Operator.Contains, requiredSubstring2, AndOr.And,
                   "this", Operator.Contains, requiredSubstring3)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4)
            : base(Operator.Contains, requiredSubstring1, AndOr.And,
                   "this", Operator.Contains, requiredSubstring2, AndOr.And,
                   "this", Operator.Contains, requiredSubstring3, AndOr.And,
                   "this", Operator.Contains, requiredSubstring4)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        /// <param name="requiredSubstring5">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5)
            : base(Operator.Contains, requiredSubstring1, AndOr.And,
                   "this", Operator.Contains, requiredSubstring2, AndOr.And,
                   "this", Operator.Contains, requiredSubstring3, AndOr.And,
                   "this", Operator.Contains, requiredSubstring4, AndOr.And,
                   "this", Operator.Contains, requiredSubstring5)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        /// <param name="requiredSubstring5">The substring value that must be contained within</param>
        /// <param name="requiredSubstring6">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5, string requiredSubstring6)
            : base(Operator.Contains, requiredSubstring1, AndOr.And,
                   "this", Operator.Contains, requiredSubstring2, AndOr.And,
                   "this", Operator.Contains, requiredSubstring3, AndOr.And,
                   "this", Operator.Contains, requiredSubstring4, AndOr.And,
                   "this", Operator.Contains, requiredSubstring5, AndOr.And,
                   "this", Operator.Contains, requiredSubstring6)
        { }

        /// <summary>
        /// Validates that the string value of a property contains all the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        /// <param name="requiredSubstring5">The substring value that must be contained within</param>
        /// <param name="requiredSubstring6">The substring value that must be contained within</param>
        /// <param name="requiredSubstring7">The substring value that must be contained within</param>
        public ContainsAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5, string requiredSubstring6, string requiredSubstring7)
            : base(Operator.Contains, requiredSubstring1, AndOr.And,
                   "this", Operator.Contains, requiredSubstring2, AndOr.And,
                   "this", Operator.Contains, requiredSubstring3, AndOr.And,
                   "this", Operator.Contains, requiredSubstring4, AndOr.And,
                   "this", Operator.Contains, requiredSubstring5, AndOr.And,
                   "this", Operator.Contains, requiredSubstring6, AndOr.And,
                   "this", Operator.Contains, requiredSubstring7)
        { }
    }
}