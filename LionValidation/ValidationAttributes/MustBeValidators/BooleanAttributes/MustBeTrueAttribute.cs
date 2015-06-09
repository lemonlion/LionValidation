using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property value is true or case insensitive "true" string
    /// </summary>
    public class MustBeTrueAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property value is true or case insensitive "true" string
        /// </summary>
        public MustBeTrueAttribute()
            : base(Operator.EqualTo, true)
        {}
    }
}