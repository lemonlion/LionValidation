using LionValidation.Helpers;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfRegexMatchTestsModel :  TestsBaseModel
    {
        [RequiredIfRegexMatch(RegexHelper.UKPostCode, "SecondField")]
        public new string FirstField { get; set; }
    }
}