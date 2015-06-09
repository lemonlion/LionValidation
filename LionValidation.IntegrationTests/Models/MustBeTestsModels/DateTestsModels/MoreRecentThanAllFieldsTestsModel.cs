using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanAllFieldsTestsModel : TestsBaseModel
    {
        [MoreRecentThanAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}