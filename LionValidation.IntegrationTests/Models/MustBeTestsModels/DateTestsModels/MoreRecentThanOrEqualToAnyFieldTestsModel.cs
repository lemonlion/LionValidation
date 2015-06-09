using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanOrEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [MoreRecentThanOrEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}