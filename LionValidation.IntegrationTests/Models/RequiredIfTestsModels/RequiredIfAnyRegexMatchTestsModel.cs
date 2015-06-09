using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAnyRegexMatchTestsModel :  TestsBaseModel
    {
        [RequiredIfAnyRegexMatch(RegexHelper.UKPostCode, "SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}