﻿using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    /// <summary>
    /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
    /// </summary>
    public class MoreRecentThanOrEqualToAllFieldsAttribute : MustBeAttribute
    {
        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName)
        { }

        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName2)
        { }

        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName3)
        { }

        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName4)
        { }

        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName4, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName5)
        { }

        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName4, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName5, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName6)
        { }

        /// <summary>
        /// Validates a date is more recent than or equal to the date values of all comparison properties listed. Dependant value must be more recent than or equal to each and every comparison value to pass validation. 
        /// </summary>
        /// <param name="dateFieldName1">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName2">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName3">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName4">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName5">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName6">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        /// <param name="dateFieldName7">The name of a property which holds a date value in the specified date format (eg. "01/01/2000") to compare to.</param>
        public MoreRecentThanOrEqualToAllFieldsAttribute(string dateFieldName1, string dateFieldName2, string dateFieldName3, string dateFieldName4, string dateFieldName5, string dateFieldName6, string dateFieldName7)
            : base(Operator.MoreRecentThanOrEqualToField, dateFieldName1, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName2, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName3, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName4, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName5, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName6, AndOr.And,
                   "this", Operator.MoreRecentThanOrEqualToField, dateFieldName7)
        { }
    }
}