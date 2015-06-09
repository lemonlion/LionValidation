using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the string value of a property doesn't contain the given substring
    /// </summary>
    public class DoesntContainAttribute : MustBeAttribute
    {
        protected readonly string requiredSubstring;

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field must not contain \"" + requiredSubstring + "\"";
        }
        
        /// <summary>
        /// Validates that the string value of a property doesn't contain the given substring
        /// </summary>
        /// <param name="requiredSubstring">The required substring to be contained within</param>
        public DoesntContainAttribute(string requiredSubstring) 
            : base(Operator.DoesntContain, requiredSubstring)
        { this.requiredSubstring = requiredSubstring; }
    }
}