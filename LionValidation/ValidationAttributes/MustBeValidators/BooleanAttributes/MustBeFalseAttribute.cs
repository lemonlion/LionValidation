using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates that the property value is false or case insensitive "false" string
    /// </summary>
    public class MustBeFalseAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates that the property value is false or case insensitive "false" string
        /// </summary>
        public MustBeFalseAttribute()
            : base(Operator.EqualTo, false)
        {}
    }
}