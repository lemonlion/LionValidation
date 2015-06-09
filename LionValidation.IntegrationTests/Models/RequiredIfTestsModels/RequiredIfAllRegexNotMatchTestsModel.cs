using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAllRegexNotMatchTestsModel :  TestsBaseModel
    {
        [RequiredIfAllRegexNotMatch(RegexHelper.UKPostCode, "SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}