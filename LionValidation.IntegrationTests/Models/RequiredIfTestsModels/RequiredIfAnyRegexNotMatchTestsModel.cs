using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAnyRegexNotMatchTestsModel :  TestsBaseModel
    {
        [RequiredIfAnyRegexNotMatch(RegexHelper.UKPostCode, "SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}