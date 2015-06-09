using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property contains the given substring
    /// </summary>
    public class ContainsAttribute : MustBeAttribute
    {
        protected readonly string requiredSubstring;

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field must contain \"" + requiredSubstring + "\"";
        }
        
        /// <summary>
        /// Validates that the string value of a property contains the given substring
        /// </summary>
        /// <param name="requiredSubstring">The required substring to be contained within</param>
        public ContainsAttribute(string requiredSubstring) 
            : base(Operator.Contains, requiredSubstring)
        { this.requiredSubstring = requiredSubstring; }
    }
}