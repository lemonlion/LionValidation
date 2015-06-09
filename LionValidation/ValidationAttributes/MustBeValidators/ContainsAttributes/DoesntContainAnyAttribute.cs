using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property doesn't contain any of the substrings listed
    /// </summary>
    public class DoesntContainAnyAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring)
            : base(Operator.DoesntContain, requiredSubstring)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that could be contained within</param>
        /// <param name="requiredSubstring2">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring1, string requiredSubstring2)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring2)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that could be contained within</param>
        /// <param name="requiredSubstring2">The substring value that could be contained within</param>
        /// <param name="requiredSubstring3">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring3)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that could be contained within</param>
        /// <param name="requiredSubstring2">The substring value that could be contained within</param>
        /// <param name="requiredSubstring3">The substring value that could be contained within</param>
        /// <param name="requiredSubstring4">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring4)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that could be contained within</param>
        /// <param name="requiredSubstring2">The substring value that could be contained within</param>
        /// <param name="requiredSubstring3">The substring value that could be contained within</param>
        /// <param name="requiredSubstring4">The substring value that could be contained within</param>
        /// <param name="requiredSubstring5">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring4, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring5)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that could be contained within</param>
        /// <param name="requiredSubstring2">The substring value that could be contained within</param>
        /// <param name="requiredSubstring3">The substring value that could be contained within</param>
        /// <param name="requiredSubstring4">The substring value that could be contained within</param>
        /// <param name="requiredSubstring5">The substring value that could be contained within</param>
        /// <param name="requiredSubstring6">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5, string requiredSubstring6)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring4, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring5, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring6)
        { }

        /// <summary>
        /// Validates that the string value of a property doesn't contain any of the substrings listed
        /// </summary>
        /// <param name="requiredSubstring1">The substring value that could be contained within</param>
        /// <param name="requiredSubstring2">The substring value that could be contained within</param>
        /// <param name="requiredSubstring3">The substring value that could be contained within</param>
        /// <param name="requiredSubstring4">The substring value that could be contained within</param>
        /// <param name="requiredSubstring5">The substring value that could be contained within</param>
        /// <param name="requiredSubstring6">The substring value that could be contained within</param>
        /// <param name="requiredSubstring7">The substring value that could be contained within</param>
        public DoesntContainAnyAttribute(string requiredSubstring1, string requiredSubstring2, string requiredSubstring3, string requiredSubstring4, string requiredSubstring5, string requiredSubstring6, string requiredSubstring7)
            : base(Operator.DoesntContain, requiredSubstring1, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring2, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring3, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring4, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring5, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring6, AndOr.Or,
                   "this", Operator.DoesntContain, requiredSubstring7)
        { }
    }
}