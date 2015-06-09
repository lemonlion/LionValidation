using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is equal to the date value of a comparison property
    /// </summary>
    public class DateEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is equal to the date value of a comparison property
        /// </summary>
        /// <param name="comparisonField">The name of a property which contains a date value to compare to</param>
        public DateEqualToFieldAttribute(string comparisonField)
            : base(Operator.DateEqualToField, comparisonField)
        {}
    }
}