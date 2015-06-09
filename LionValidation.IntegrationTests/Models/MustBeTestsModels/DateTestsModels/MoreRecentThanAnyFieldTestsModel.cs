using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanAnyFieldTestsModel : TestsBaseModel
    {
        [MoreRecentThanAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}