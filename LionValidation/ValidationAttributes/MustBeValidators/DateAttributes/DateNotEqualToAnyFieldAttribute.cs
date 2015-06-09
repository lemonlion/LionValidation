using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
    /// </summary>
    public class DateNotEqualToAnyFieldAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName)
            : base(Operator.DateNotEqualToField, dateFieldName)
        { }

        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName1, string dateFieldName2)
            : base(Operator.DateNotEqualToField, dateFieldName1, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName2)
        { }

        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3)
            : base(Operator.DateNotEqualToField, dateFieldName1, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName2, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName3)
        { }

        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4)
            : base(Operator.DateNotEqualToField, dateFieldName1, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName2, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName3, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName4)
        { }

        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5)
            : base(Operator.DateNotEqualToField, dateFieldName1, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName2, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName3, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName4, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName5)
        { }

        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6)
            : base(Operator.DateNotEqualToField, dateFieldName1, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName2, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName3, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName4, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName5, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName6)
        { }

        /// <summary>
        /// Validates a date is not equal to the date values of any properties listed. Dependant value must be not equal to at least one of the comparison values to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName7">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public DateNotEqualToAnyFieldAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6, string dateFieldName7)
            : base(Operator.DateNotEqualToField, dateFieldName1, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName2, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName3, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName4, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName5, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName6, AndOr.Or,
                   "this", Operator.DateNotEqualToField, dateFieldName7)
        { }
    }
}