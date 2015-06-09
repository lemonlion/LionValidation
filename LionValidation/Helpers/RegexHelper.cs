namespace LionValidation.Helpers
{
    public static class RegexHelper
    {
        public const string UKPostCode = @"^(([gG][iI][rR] {0,}0[aA]{2})|((([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y]?[0-9][0-9]?)|(([a-pr-uwyzA-PR-UWYZ][0-9][a-hjkstuwA-HJKSTUW])|([a-pr-uwyzA-PR-UWYZ][a-hk-yA-HK-Y][0-9][abehmnprv-yABEHMNPRV-Y]))) {0,}[0-9][abd-hjlnp-uw-zABD-HJLNP-UW-Z]{2}))$";
        public const string UKBankAccountNumber = @"[0-9]{8}";
        public const string UKDate = @"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$";
        public const string UKDateStrict = @"^([0-2][0-9]|[3][0-1])/([0][0-9]|[1][0-2])/([0-2][0-9][0-9][0-9])$";
        public const string MoneyValueAllowCommas = @"^([1-9]{1}[\d]{0,2}(\,[\d]{3})*(\.[\d]{2})?|[1-9]{1}[\d]{0,}(\.[\d]{2})?|0(\.[\d]{2})?|(\.[\d]{1,2})?)$";
        public const string MoneyValueNoCommas = @"^[0-9]+(\.[0-9][0-9])?$";
        public const string Email = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,15}$";
        public const string PositiveInteger = @"^[1-9]\d*$";
        public const string PositiveIntegerOrZero = @"^([1-9]\d*)$|^0$";
        public const string Integer = @"^(-?[1-9]\d*)$|^(0)$";
        public const string NegativeIntegerOrZero = @"^(-[1-9]\d*)$|^(0)$";
        public const string NegativeInteger = @"^-[1-9]\d*$";
        public const string Digits = @"^[0-9]\d*$";
        public const string StringDoesntContain = @"^((?!STRINGYOUDONTWANT).)*$";
        public const string StringNoNumbers = @"^((?![0-9]).)*$";
        public const string Telephone = @"^[0-9 \(\)\+\-]{7,18}$";
        public const string URL = @"^(https?|ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(\#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$";
    }
}

// TODO: Implement LongerThan/ShorterThan Operator
// TODO: EqualToNumeric Vs EqualToString
// TODO: Change client side field search to get by name first
// TODO: Implement "this" functionality server & client side
// TODO: Fix equality blanks int vs strings issue
// TODO: Implement Contains/DoesntContain Operator
// TODO: Implement lambda .ToString(...) => .toString()
// TODO: Implement lambda Int.Parse(...) => parseInt(...)
// TODO: Implement lambda Double.Parse(...) => parseFloat(...)
// TODO: Implement lambda .Contains(...) => indexOf(...) != -1 (implement as lionStringContains)
// TODO: Implement OlderThan MoreRecentOrEqualThan DateTime for fixed formats

// Release TODO
// TODO: Selenium Integration Tests
// TODO: Comment Documentation
// TODO: One unit test
// TODO: Documentation
// TODO: Website

// Release Feature list

// Nice To Have
// TODO: Implement lambda stuff with property type checking
// TODO: Implement proper parsers for expression evaluation