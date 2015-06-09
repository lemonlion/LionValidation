using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using LionValidation.Enums;
using LionValidation.Helpers;

namespace LionValidation.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class RequiredIfAttribute : ValidationAttribute, IClientValidatable
    {
        protected readonly RequiredAttribute requiredAttribute = new RequiredAttribute();
        protected static int AttributeIteratorForThisField { get; set; } // TODO: Check if this needs to be public or private

        public Bracket CloseWithBrackets { get; set; }
        public bool ReverseValidationResult { get; set; }
        public string DateFormat { get; set; }
        public bool DisableClientSideValidation { get; set; }

        protected Validator validator { get; set; }
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool validationResult = validator.Evaluate(validationContext.ObjectInstance, closingBrackets: CloseWithBrackets);

            bool isRequired = ReverseValidationResult ? !validationResult : validationResult;

            if (isRequired && !requiredAttribute.IsValid(value))
                return new ValidationResult(ErrorMessage, new[] { validationContext.MemberName });

            return ValidationResult.Success;
        }

        public override string FormatErrorMessage(string name)
        {
            return "The " + name + " field is required";
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            if (DisableClientSideValidation)
                return new List<ModelClientValidationRule>();

            Type baseType = Type.GetType(metadata.ContainerType.AssemblyQualifiedName);

            PropertyInfo thisProperty = baseType.GetProperty(metadata.PropertyName);
            List<CustomAttributeData> attributesList = thisProperty.CustomAttributes.ToList();
            var totalCount = attributesList.Count(x => typeof(RequiredIfAttribute).IsAssignableFrom(x.AttributeType));

            if (totalCount > 10)
                throw new Exception("No more than 10 RequiredIf validators allowed per field");

            AttributeIteratorForThisField++;

            if (AttributeIteratorForThisField > totalCount)
                AttributeIteratorForThisField = 1;

            var rule = new ModelClientValidationRule
            {
                ErrorMessage = String.IsNullOrEmpty(ErrorMessage) ? FormatErrorMessage(String.IsNullOrEmpty(metadata.DisplayName) ? metadata.PropertyName : metadata.DisplayName) : ErrorMessage,
                ValidationType = "requiredif" + AttributeIteratorForThisField.ToAsciiLetter()
            };

            if (ReverseValidationResult)
                rule.ValidationParameters.Add("reverse", "true");

            if (validator.DateFormatNeeded)
                rule.ValidationParameters.Add("dateformat", validator.DateFormat);

            if (validator.UseSimpleClientSideValidation)
            {
                rule.ValidationParameters.Add("dependants", validator.GetClientSideDependentFields(baseType, thisProperty));
                rule.ValidationParameters.Add("comparisons", validator.GetClientSideComparisonValues(baseType));
                rule.ValidationParameters.Add("operators", validator.GetClientSideOperators());
                rule.ValidationParameters.Add("conjuctions", validator.GetClientSideConjuctions(CloseWithBrackets));
            }
            else
                rule.ValidationParameters.Add("validationexpression", validator.ClientSideExpression(baseType));

            return new List<ModelClientValidationRule> { rule };
        }
        
        private object _typeId = new object();
        public override object TypeId { get { return this._typeId; } }

        public RequiredIfAttribute(string requiredIfExpression)
        {
            validator = new Validator(requiredIfExpression);
        }

        public RequiredIfAttribute(string dependantField, params string[] permittedValues)
            : this(dependantField, Operator.EqualTo, permittedValues)
        { }

        /// <summary>
        /// Validates that the property compares favourably with any of the values listed
        /// </summary>
        /// <param name="dependantField">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue">Comparison operator for the given property</param>
        /// <param name="valuesOrFieldNamesOrRegularExpressions">List of comparison values to compare with the property.  Depending on the operator, each parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField, Operator operatorValue, params string[] valuesOrFieldNamesOrRegularExpressions)
        {
            validator = new Validator(dependantField, operatorValue, DateFormat, valuesOrFieldNamesOrRegularExpressions);
        }

        /// <summary>
        /// Sets property to required if it meets validation criteria
        /// </summary>
        /// <param name="dependantField">Name of the property to compare to the comparison value.</param>
        /// <param name="operatorValue">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression">Comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField, Operator operatorValue, object valueOrFieldNameOrRegularExpression)
        {
            validator = new Validator(null, DateFormat, dependantField, operatorValue, valueOrFieldNameOrRegularExpression);
        }

        /// <summary>
        /// Sets property to required if it meets both the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2)
        {
            validator = new Validator(null, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3)
        {
            validator = new Validator(null, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4)
        {
            validator = new Validator(null, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr4">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField5">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue5">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression5">Fifth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5)
        {
            validator = new Validator(null, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                      dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr4">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField5">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue5">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression5">Fifth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr5">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField6">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue6">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression6">Sixth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6)
        {
            validator = new Validator(null, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                      dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                      dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr4">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField5">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue5">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression5">Fifth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr5">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField6">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue6">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression6">Sixth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr6">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField7">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue7">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression7">Seventh comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6, AndOr andOr6,
                                   string dependantField7, Operator operatorValue7, object valueOrFieldNameOrRegularExpression7)
        {
            validator = new Validator(null, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                      dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                      dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6, andOr6,
                                      dependantField7, operatorValue7, valueOrFieldNameOrRegularExpression7);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="openingBrackets">Opening brackets</param>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3)
        {
            validator = new Validator(openingBrackets, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="openingBrackets">Opening brackets</param>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4)
        {
            validator = new Validator(openingBrackets, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="openingBrackets">Opening brackets</param>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr4">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField5">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue5">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression5">Fifth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5)
        {
            validator = new Validator(openingBrackets, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                      dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="openingBrackets">Opening brackets</param>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr4">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField5">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue5">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression5">Fifth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr5">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField6">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue6">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression6">Sixth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6)
        {
            validator = new Validator(openingBrackets, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                      dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                      dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6);
        }

        /// <summary>
        /// Sets property to required if it meets all the validation criteria listed
        /// </summary>
        /// <param name="openingBrackets">Opening brackets</param>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr2">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField3">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue3">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression3">Third comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr3">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField4">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue4">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression4">Fourth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr4">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField5">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue5">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression5">Fifth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr5">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField6">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue6">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression6">Sixth comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr6">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField7">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue7">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression7">Seventh comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6, AndOr andOr6,
                                   string dependantField7, Operator operatorValue7, object valueOrFieldNameOrRegularExpression7)
        {
            validator = new Validator(openingBrackets, DateFormat, dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                      dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                      dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                      dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                      dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                      dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6, andOr6,
                                      dependantField7, operatorValue7, valueOrFieldNameOrRegularExpression7);
        }
    }
}