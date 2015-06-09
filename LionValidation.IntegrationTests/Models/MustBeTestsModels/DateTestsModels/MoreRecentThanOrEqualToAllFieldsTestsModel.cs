using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanOrEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [MoreRecentThanOrEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}