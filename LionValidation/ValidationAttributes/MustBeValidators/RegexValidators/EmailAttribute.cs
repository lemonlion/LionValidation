using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property's value conforms to the format of a valid email address
    /// </summary>
    public class EmailAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property's value conforms to the format of a valid email address
        /// </summary>
        public EmailAttribute()
            : base(Operator.MatchesRegularExpression, RegexHelper.Email)
        {}
    }
}