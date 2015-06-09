using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfRegexNotMatchTestsModel :  TestsBaseModel
    {
        [RequiredIfRegexNotMatch(RegexHelper.UKPostCode, "SecondField")]
        public new string FirstField { get; set; }
    }
}