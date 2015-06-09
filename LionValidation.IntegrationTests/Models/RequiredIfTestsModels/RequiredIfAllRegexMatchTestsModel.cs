using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAllRegexMatchTestsModel :  TestsBaseModel
    {
        [RequiredIfAllRegexMatch(RegexHelper.UKPostCode, "SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}