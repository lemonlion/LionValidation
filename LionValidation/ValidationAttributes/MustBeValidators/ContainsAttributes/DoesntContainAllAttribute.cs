using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
    /// </summary>
    public class DoesntContainAllAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring)
            : base(Operator.DoesntContain, requiredSubstring)
        {}

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring1, string requiredSubstring2)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring2)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring3)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring4)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        /// <param name="requiredSubstring5">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring4, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring5)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        /// <param name="requiredSubstring5">The substring value that must be contained within</param>
        /// <param name="requiredSubstring6">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5, string requiredSubstring6)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring4, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring5, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring6)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain every one of the substrings listed.  Validation fails if and only if all the substrings are contained within.
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that must be contained within</param>
        /// <param name="requiredSubstring2">The substring value that must be contained within</param>
        /// <param name="requiredSubstring3">The substring value that must be contained within</param>
        /// <param name="requiredSubstring4">The substring value that must be contained within</param>
        /// <param name="requiredSubstring5">The substring value that must be contained within</param>
        /// <param name="requiredSubstring6">The substring value that must be contained within</param>
        /// <param name="requiredSubstring7">The substring value that must be contained within</param>
        public DoesntContainAllAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5, string requiredSubstring6, string requiredSubstring7)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring4, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring5, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring6, AndOr.And,
                   "this", Operator.DoesntContain, requiredSubstring7)
        { }
    }
}