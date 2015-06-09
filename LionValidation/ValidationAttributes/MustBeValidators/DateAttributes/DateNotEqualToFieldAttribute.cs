using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is not equal to the date value of a comparison property
    /// </summary>
    public class DateNotEqualToFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is not equal to the date value of a comparison property
        /// </summary>
        /// <param name="dateFieldName">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToFieldAttribute(string dateFieldName)
            : base(Operator.DateNotEqualToField, dateFieldName)
        {}
    }
}