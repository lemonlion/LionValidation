using LionValidation.Enums;

namespace LionValidation.ValidationAttributes
{
    public class RequiredIfNotAttribute : RequiredIfAttribute
    {
        public RequiredIfNotAttribute(string requiredIfExpression)
            : base(requiredIfExpression)
        { ReverseValidationResult = !ReverseValidationResult; }

        public RequiredIfNotAttribute(string dependantField, params string[] permittedValues)
            : base(dependantField, permittedValues)
        { ReverseValidationResult = !ReverseValidationResult; }

        public RequiredIfNotAttribute(string dependantField, Operator operatorValue, params string[] valuesOrFieldNamesOrRegularExpressions)
            : base(dependantField, operatorValue, valuesOrFieldNamesOrRegularExpressions)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet validation criteria
        /// </summary>
        /// <param name="dependantField">Name of the property to compare to the comparison value.</param>
        /// <param name="operatorValue">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression">Comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfNotAttribute(string dependantField, Operator operatorValue, object valueOrFieldNameOrRegularExpression)
            : base(dependantField, operatorValue, valueOrFieldNameOrRegularExpression)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet both the validation criteria listed
        /// </summary>
        /// <param name="dependantField1">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue1">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression1">First comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        /// <param name="andOr1">'AndOr' enumeration value representing the conjuction connecting the previous validation criteria to the next.  This value may be "And" or "Or" and may contain opening or closing brackets.</param>
        /// <param name="dependantField2">Name of the property to compare to the next comparison value.</param>
        /// <param name="operatorValue2">Comparison operator for the given property</param>
        /// <param name="valueOrFieldNameOrRegularExpression2">Second comparison value.  Depending on the previous operator, this parameter may be a property value or name or regular expression.</param>
        public RequiredIfNotAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                      string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2)
            : base(dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3)
            : base(dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4)
            : base(dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5)
            : base(dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                           dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6)
            : base(dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                           dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr3,
                                           dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6, AndOr andOr6,
                                   string dependantField7, Operator operatorValue7, object valueOrFieldNameOrRegularExpression7)
            : base(dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                           dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                           dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6, andOr6,
                                           dependantField7, operatorValue7, valueOrFieldNameOrRegularExpression7)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3)
                                : base(openingBrackets,
                                           dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4)
                                : base(openingBrackets,
                                           dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5)
                                : base(openingBrackets,
                                           dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                           dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6)
                                 : base(openingBrackets,
                                           dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                           dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                           dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6)
        { ReverseValidationResult = !ReverseValidationResult; }

        /// <summary>
        /// Sets property to required if it doesn't meet all the validation criteria listed
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
        public RequiredIfNotAttribute(Bracket openingBrackets,
                                   string dependantField1, Operator operatorValue1, object valueOrFieldNameOrRegularExpression1, AndOr andOr1,
                                   string dependantField2, Operator operatorValue2, object valueOrFieldNameOrRegularExpression2, AndOr andOr2,
                                   string dependantField3, Operator operatorValue3, object valueOrFieldNameOrRegularExpression3, AndOr andOr3,
                                   string dependantField4, Operator operatorValue4, object valueOrFieldNameOrRegularExpression4, AndOr andOr4,
                                   string dependantField5, Operator operatorValue5, object valueOrFieldNameOrRegularExpression5, AndOr andOr5,
                                   string dependantField6, Operator operatorValue6, object valueOrFieldNameOrRegularExpression6, AndOr andOr6,
                                   string dependantField7, Operator operatorValue7, object valueOrFieldNameOrRegularExpression7)
                                   : base(openingBrackets,
                                           dependantField1, operatorValue1, valueOrFieldNameOrRegularExpression1, andOr1,
                                           dependantField2, operatorValue2, valueOrFieldNameOrRegularExpression2, andOr2,
                                           dependantField3, operatorValue3, valueOrFieldNameOrRegularExpression3, andOr3,
                                           dependantField4, operatorValue4, valueOrFieldNameOrRegularExpression4, andOr4,
                                           dependantField5, operatorValue5, valueOrFieldNameOrRegularExpression5, andOr5,
                                           dependantField6, operatorValue6, valueOrFieldNameOrRegularExpression6, andOr6,
                                           dependantField7, operatorValue7, valueOrFieldNameOrRegularExpression7)
            { ReverseValidationResult = !ReverseValidationResult; }

    }
}