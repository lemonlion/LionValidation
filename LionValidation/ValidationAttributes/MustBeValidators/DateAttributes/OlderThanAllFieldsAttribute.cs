using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
    /// </summary>
    public class OlderThanAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName)
            : base(Operator.OlderThanField, dateFieldName)
        {}

        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2)
            : base(Operator.OlderThanField, dateFieldName1, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName2)
        { }

        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3)
            : base(Operator.OlderThanField, dateFieldName1, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName2, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName3)
        { }

        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4)
            : base(Operator.OlderThanField, dateFieldName1, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName2, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName3, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName4)
        { }

        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5)
            : base(Operator.OlderThanField, dateFieldName1, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName2, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName3, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName4, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName5)
        { }

        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6)
            : base(Operator.OlderThanField, dateFieldName1, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName2, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName3, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName4, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName5, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName6)
        { }

        /// <summary>
        /// Validates a date is older than the date values of all comparison properties listed. Dependant value must be older than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName7">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public OlderThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6, string dateFieldName7)
            : base(Operator.OlderThanField, dateFieldName1, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName2, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName3, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName4, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName5, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName6, AndOr.And,
                   "this", Operator.OlderThanField, dateFieldName7)
        { }
    }
}