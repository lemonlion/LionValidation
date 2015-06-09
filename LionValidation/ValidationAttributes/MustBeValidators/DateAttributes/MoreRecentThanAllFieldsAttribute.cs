﻿using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
    /// </summary>
    public class MoreRecentThanAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName)
            : base(Operator.MoreRecentThanField, dateFieldName)
        {}

        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2)
            : base(Operator.MoreRecentThanField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName2)
        { }

        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3)
            : base(Operator.MoreRecentThanField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName3)
        { }

        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4)
            : base(Operator.MoreRecentThanField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName4)
        { }

        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5)
            : base(Operator.MoreRecentThanField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName4, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName5)
        { }

        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6)
            : base(Operator.MoreRecentThanField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName4, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName5, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName6)
        { }

        /// <summary>
        /// Validates a date is more recent than the date values of all comparison properties listed. Dependant value must be more recent than each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName7">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6, string dateFieldName7)
            : base(Operator.MoreRecentThanField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName4, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName5, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName6, AndOr.And,
                   "this", Operator.MoreRecentThanField, dateFieldName7)
        { }
    }
}