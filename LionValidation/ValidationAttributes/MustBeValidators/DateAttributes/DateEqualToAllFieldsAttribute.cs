using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
    /// </summary>
    public class DateEqualToAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName)
            : base(Operator.DateEqualToField, dateFieldName)
        {}

        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2)
            : base(Operator.DateEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName2)
        { }

        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3)
            : base(Operator.DateEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName3)
        { }

        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4)
            : base(Operator.DateEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName4)
        { }

        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5)
            : base(Operator.DateEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName4, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName5)
        { }

        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6)
            : base(Operator.DateEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName4, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName5, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName6)
        { }

        /// <summary>
        /// Validates a date is equal to the date values of all properties listed. Dependant value must be equal to each and every comparison value to pass validation.
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName7">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6, string dateFieldName7)
            : base(Operator.DateEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName4, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName5, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName6, AndOr.And,
                   "this", Operator.DateEqualToField, dateFieldName7)
        { }
    }
}