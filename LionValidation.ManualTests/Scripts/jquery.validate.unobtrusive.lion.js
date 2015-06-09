var LionSpace = {

    requiredIfValidatorBaseName: "requiredif",
    mustBeValidatorBaseName: "mustbe",

    initialiseValidation: function ()
    {
        for (var i = 0; i < 10; i++)
        {
            var additionalLetter = String.fromCharCode(97 + i);

            var validatorRequiredIfName = LionSpace.requiredIfValidatorBaseName + additionalLetter;
            var validatorMustBeName = LionSpace.mustBeValidatorBaseName + additionalLetter;

            $.validator.addMethod(validatorRequiredIfName, LionSpace.validateRequiredIf);
            $.validator.addMethod(validatorMustBeName, LionSpace.validateMustBe);

            var paramsArray = ['validationexpression', 'dependants', 'operators', 'comparisons', 'conjuctions', 'reverse', 'validateonnull', 'dateformat'];

            // Must pass in literals into the standardUnobtrusiveAdapterFunction or it will just pass in a pointer to the 
            // final value of the variable, hence the switch statement rather than using the incremented variable
            switch (i)
            {
                case 0:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifa"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbea"); });
                case 1:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifb"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbeb"); });
                case 2:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifc"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbec"); });
                case 3:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifd"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbed"); });
                case 4:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredife"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbee"); });
                case 5:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requirediff"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbef"); });
                case 6:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifg"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbeg"); });
                case 7:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifh"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbeh"); });
                case 8:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifi"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbei"); });
                case 9:
                    $.validator.unobtrusive.adapters.add(validatorRequiredIfName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "requiredifj"); });
                    $.validator.unobtrusive.adapters.add(validatorMustBeName, paramsArray, function (options) { LionSpace.standardUnobtrusiveAdapterFunction(options, "mustbej"); });
            }
        }
    },

    standardUnobtrusiveAdapterFunction: function (options, validatorNewName)
    {
        if (options.params['validationexpression'] != null)
        {
            options.rules[validatorNewName] = {
                validationexpression: LionSpace.preformatExpression(options.params['validationexpression']),

                reverse: LionSpace.toBool(options.params['reverse']),
                validateonnull: LionSpace.toBool(options.params['validateonnull']),
                dateformat: options.params['dateformat']
            };
        }
        else if (options.params['dependants'] != null)
        {
            options.rules[validatorNewName] = {
                dependants: options.params['dependants'].split(','),
                operators: options.params['operators'].split(','),
                comparisons: options.params['comparisons'].split('^|^'),
                conjuctions: options.params['conjuctions'] == "" ? [] : options.params['conjuctions'].split(','),

                reverse: LionSpace.toBool(options.params['reverse']),
                validateonnull: LionSpace.toBool(options.params['validateonnull']),
                dateformat: options.params['dateformat']
            };
        }
        options.messages[validatorNewName] = options.message;
    },

    getElementValue: function (targetLocalName, currentInputName)
    {
        var currentInputLocalName = currentInputName.split(".")[currentInputName.split(".").length - 1];
        var currentNameContext = currentInputName.slice(0, currentInputName.length - currentInputLocalName.length);
        var targetFullName = currentNameContext + targetLocalName;

        return LionSpace.getElementValueUsingFullName(targetFullName);
    },

    getElementValueUsingFullName: function (targetFullName)
    {
        var targetElement;

        var targetElements = $("[name='" + targetFullName + "']").filter("input, select, textarea").not(":disabled");

        if (targetElements.length == 1)
        {
            targetElement = $(targetElements).first();
        }
        else if (targetElements.length > 1)
        {
            for (var i = 0; i < targetElements.length; i++)
            {
                if ($(targetElements[i]).is("input[type='radio']") || $(targetElements[i]).is("input[type='checkbox']"))
                {
                    if ($(targetElements[i]).is(":checked"))
                    {
                        targetElement = $(targetElements[i]);
                        break;
                    }
                }
                else
                {
                    targetElement = $(targetElements[i]);
                    break;
                }
            }
        }
        else // (targetElements.length == 0)
            return null;

        var targetElementValue = $(targetElement).val();

        //console.log("targetElementValue: " + targetElementValue);

        return targetElementValue;
    },

    evaluateComplexExpression: function (expression, currentInput)
    {
        var currentInputName = $(currentInput).attr("name");
        var currentInputId = $(currentInput).attr("id");

        //console.log("currentInputName: " + currentInputName);
        //console.log("currentInputId: " + currentInputId);

        expression = expression.replace(/~#CURRENTINPUTNAME#~/g, currentInputName);

        //console.log(expression); // Uncomment for debugging

        var isValid = new Function("return " + expression)();

        return isValid;
    },

    evaluate: function (dependantProperties, operators, comparisonValues, conjuctions, currentInput, dateFormat)
    {
        if (dependantProperties.length == 1)
            return LionSpace.evaluateStatement(dependantProperties[0], operators[0], comparisonValues[0], currentInput, dateFormat);

        var expression = "(";
        for (var i = 0; i < dependantProperties.length; i++)
        {
            expression += LionSpace.evaluateStatement(dependantProperties[i], operators[i], comparisonValues[i], currentInput, dateFormat);
            if (i < conjuctions.length)
                expression += " " + conjuctions[i].replace(/&/g, '&&').replace(/\|/g, '||') + " ";
        }
        expression += ")";

        //console.log(expression);

        var isValid = new Function("return " + expression)();

        return isValid;

        //var expressionArray = [];
        //for (var i = 0; i < dependantProperties.length; i++)
        //{
        //    expressionArray.push(LionSpace.evaluateStatement(dependantProperties[i], operators[i], comparisonValues[i], currentInput));
        //    if (i < conjuctions.length)
        //        expressionArray.push(conjuctions[i]);
        //}
        //expressionArray = expressionArray.reverse();

        //return LionSpace.evaluateExpressionArray(expressionArray);
    },

    testevaluate: function (evaluationString)
    {
        var expressionArray = evaluationString.replace(/&&/g, '&').replace(/\|\|/g, '|').split(" ").reverse();
        return LionSpace.evaluateExpressionArray(expressionArray);
    },

    evaluateExpressionArray: function (expressionArray)
    {
        if (expressionArray.length == 1)
            return expressionArray[0];
        else
        {
            var bool1 = expressionArray.pop();
            var conjuction = expressionArray.pop();

            switch (conjuction)
            {
                case "&":
                    var bool2 = expressionArray.pop();
                    expressionArray.push(bool1 && bool2);
                    return LionSpace.evaluateExpressionArray(expressionArray);
                    break;
                case "|": case ")|": case "|(": case ")|(":
                    return bool1 || LionSpace.evaluateExpressionArray(expressionArray);
                    break;
                case ")&": case "&(": case ")&(":
                    return bool1 && LionSpace.evaluateExpressionArray(expressionArray);
            }
        }

        return false;
    },

    evaluateStatement: function (dependantProperty, operator, comparisonValue, currentInput, dateFormat)
    {
        var dependantPropertyValue;
        if (dependantProperty == "this")
            dependantPropertyValue = LionSpace.getElementValueUsingFullName($(currentInput).attr("name"));
        else if (dependantProperty == "bp.this")
            dependantPropertyValue = LionSpace.toBool(LionSpace.getElementValueUsingFullName($(currentInput).attr("name")));
        else if (dependantProperty.indexOf("bp.") == 0)
            dependantPropertyValue = LionSpace.toBool(LionSpace.getElementValue(dependantProperty.replace("bp.", ""), $(currentInput).attr("name")));
        else
            dependantPropertyValue = LionSpace.getElementValue(dependantProperty.replace("p.", ""), $(currentInput).attr("name"));

        var comparisonActualValue;
        if (comparisonValue.indexOf("p.") == 0)
        {
            comparisonActualValue = LionSpace.getElementValue(comparisonValue.replace("p.", ""), $(currentInput).attr("name"));
            if (operator.indexOf("L") == 0)
                comparisonActualValue = comparisonActualValue.length;
        }
        else if (comparisonValue.indexOf("bp.") == 0)
            comparisonActualValue = LionSpace.toBool(LionSpace.getElementValue(comparisonValue.replace("bp.", ""), $(currentInput).attr("name")));
        else if (comparisonValue.indexOf("b.") == 0)
            comparisonActualValue = LionSpace.toBool(comparisonValue.replace("b.", ""));
        else
            comparisonActualValue = comparisonValue.replace("s.", "");

        var dependantPropertyNumberValue;
        var comparisonNumberValue;

        var dependantPropertyDateValue;
        var comparisonDateValue;

        switch (operator)
        {
            case ">": case ">=": case "<": case "<=": case "=": case "!=":
                dependantPropertyNumberValue = parseFloat(dependantPropertyValue);
                comparisonNumberValue = parseFloat(comparisonActualValue);

                if (isNaN(dependantPropertyNumberValue) || isNaN(comparisonActualValue) == null)
                    return false; // The values are not valid for numbers so can't be compared, validation fails
                break;

            case "D>": case "D>=": case "D<": case "D<=": case "D=": case "D!=":
                dependantPropertyDateValue = LionSpace.getDate(dependantPropertyValue, dateFormat);
                comparisonDateValue = LionSpace.getDate(comparisonActualValue, dateFormat);

                if (dependantPropertyDateValue == null || comparisonDateValue == null)
                    return false; // The values are not valid for dates so can't be compared, validation fails
                break;
        }

        dependantPropertyValue = dependantPropertyValue != null ? dependantPropertyValue : "";
        comparisonActualValue = comparisonActualValue != null ? comparisonActualValue : "";

        var result;

        try
        {
            switch (operator)
            {
                case ">":
                    result = dependantPropertyNumberValue > comparisonNumberValue;
                    break;
                case ">=":
                    result = dependantPropertyNumberValue >= comparisonNumberValue;
                    break;
                case "<":
                    result = dependantPropertyNumberValue < comparisonNumberValue;
                    break;
                case "<=":
                    result = dependantPropertyNumberValue <= comparisonNumberValue;
                    break;
                case "=":
                    result = dependantPropertyNumberValue == comparisonNumberValue;
                    break;
                case "!=":
                    result = dependantPropertyNumberValue != comparisonNumberValue;
                    break;
                case "==":
                    result = dependantPropertyValue == comparisonActualValue;
                    break;
                case "!==":
                    result = dependantPropertyValue != comparisonActualValue;
                    break;
                case "L>":
                    result = dependantPropertyValue.length > comparisonActualValue;
                    break;
                case "L>=":
                    result = dependantPropertyValue.length >= comparisonActualValue;
                    break;
                case "L<":
                    result = dependantPropertyValue.length < comparisonActualValue;
                    break;
                case "L<=":
                    result = dependantPropertyValue.length <= comparisonActualValue;
                    break;
                case "L=":
                    result = dependantPropertyValue.length == comparisonActualValue;
                    break;
                case "L!=":
                    result = dependantPropertyValue.length != comparisonActualValue;
                    break;
                case "D>":
                    result = dependantPropertyDateValue > comparisonDateValue;
                    break;
                case "D>=":
                    result = dependantPropertyDateValue >= comparisonDateValue;
                    break;
                case "D<":
                    result = dependantPropertyDateValue < comparisonDateValue;
                    break;
                case "D<=":
                    result = dependantPropertyDateValue <= comparisonDateValue;
                    break;
                case "D=":
                    result = dependantPropertyDateValue.getTime() == comparisonDateValue.getTime();
                    break;
                case "D!=":
                    result = dependantPropertyDateValue.getTime() != comparisonDateValue.getTime();
                    break;
                case "rgx":
                    result = new RegExp(comparisonActualValue).test(dependantPropertyValue);
                    break;
                case "!rgx":
                    result = !(new RegExp(comparisonActualValue).test(dependantPropertyValue));
                    break;
                case "ctn":
                    result = dependantPropertyValue.indexOf(comparisonActualValue) != -1;
                    break;
                case "!ctn":
                    result = dependantPropertyValue.indexOf(comparisonActualValue) == -1;
                    break;
            }
        }
        catch (e)
        {
            return false;
        }

        return result;
    },

    validateRequiredIf: function (value, element, parameters)
    {
        var reverseValidationResult = LionSpace.toBool(parameters['reverse']);
        var validationExpression = parameters['validationexpression'];

        var validationResult;

        if (validationExpression == null)
        {
            var dependantProperties = parameters['dependants'];
            var operators = parameters['operators'];
            var comparisonValues = parameters['comparisons'];
            var conjuctions = parameters['conjuctions'];
            var dateFormat = parameters['dateformat'];

            validationResult = LionSpace.evaluate(dependantProperties, operators, comparisonValues, conjuctions, element, dateFormat);
        }
        else
            validationResult = LionSpace.evaluateComplexExpression(validationExpression, element);

        var isRequired = (reverseValidationResult) ? !(validationResult) : validationResult;

        if (isRequired)
            return $.validator.methods.required.call(this, value, element, parameters);

        return true;
    },

    validateMustBe: function (value, element, parameters)
    {
        var validateOnNull = LionSpace.toBool(parameters['validateonnull']);
        var thisValue = LionSpace.getElementValueUsingFullName(element.name);
        var validate = (thisValue != null && thisValue.toString() != "") || validateOnNull;

        var isValid;

        if (!validate)
        {
            isValid = true;
        }
        else
        {
            var reverseValidationResult = LionSpace.toBool(parameters['reverse']);
            var validationExpression = parameters['validationexpression'];

            var validationResult;

            if (validationExpression == null)
            {
                var dependantProperties = parameters['dependants'];
                var operators = parameters['operators'];
                var comparisonValues = parameters['comparisons'];
                var conjuctions = parameters['conjuctions'];
                var dateFormat = parameters['dateformat'];

                validationResult = LionSpace.evaluate(dependantProperties, operators, comparisonValues, conjuctions, element, dateFormat);
            }
            else
                validationResult = LionSpace.evaluateComplexExpression(validationExpression, element);

            isValid = reverseValidationResult ? !(validationResult) : validationResult;
        }

        return isValid;
    },


    preformatExpression: function (expression)
    {
        //console.log("Expression before: " + expression);
        expression = expression.replace(/{/g, "LionSpace.getElementValue('");
        expression = expression.replace(/}/g, "', '~#CURRENTINPUTNAME#~')");
        //console.log("Expression after: " + expression);
        return expression;
    },

    toBool: function (boolStringOrBool)
    {
        return boolStringOrBool == null ? false : (boolStringOrBool.toString().toLowerCase() == "true");
    },

    getDate: function (dateString, dateFormat)
    {
        var escapedDateFormat = dateFormat.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&');

        var dayRegex = new RegExp(escapedDateFormat.lionReplaceAll("dd", "(\\q\\q)").lionReplaceAll("d", "(\\q\\q\?)")
                                                   .lionReplaceAll("MM", "\\q\\q").lionReplaceAll("M", "\\q\\q\?")
                                                   .lionReplaceAll("yyyy", "\\q\\q\\q\\q").lionReplaceAll("yy", "\\q\\q\\q\?\\q\?")
                                                   .lionReplaceAll("q", "d"), "g");

        var monthRegex = new RegExp(escapedDateFormat.lionReplaceAll("dd", "\\q\\q").lionReplaceAll("d", "\\q\\q\?")
                                                     .lionReplaceAll("MM", "(\\q\\q)").lionReplaceAll("M", "(\\q\\q\?)")
                                                     .lionReplaceAll("yyyy", "\\q\\q\\q\\q").lionReplaceAll("yy", "\\q\\q\\q\?\\q\?")
                                                     .lionReplaceAll("q", "d"), "g");

        var yearRegex = new RegExp(escapedDateFormat.lionReplaceAll("dd", "\\q\\q").lionReplaceAll("d", "\\q\\q\?")
                                                    .lionReplaceAll("MM", "\\q\\q").lionReplaceAll("M", "\\q\\q\?")
                                                    .lionReplaceAll("yyyy", "(\\q\\q\\q\\q)").lionReplaceAll("yy", "(\\q\\q\\q\?\\q\?)")
                                                    .lionReplaceAll("q", "d"), "g");

        try
        {
            var year = parseInt(yearRegex.exec(dateString)[1]);
            var month = parseInt(monthRegex.exec(dateString)[1]);
            var day = parseInt(dayRegex.exec(dateString)[1]);

            if (year < 100)
                year = year + 2000;
            if (year > (new Date()).getFullYear())
                year = year - 100;

            return new Date(year, month - 1, day);
        }
        catch (e)
        {
            return null;
        }
    }
};

String.prototype.lionStringContains = function (substring)
{
    return this.indexOf(substring) != -1;
};

String.prototype.lionReplaceAll = function (find, replace)
{
    return this.replace(new RegExp(find.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&'), 'g'), replace);
};

LionSpace.initialiseValidation();