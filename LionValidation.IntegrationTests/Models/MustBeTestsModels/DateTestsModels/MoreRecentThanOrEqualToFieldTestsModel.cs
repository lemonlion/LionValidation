using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanOrEqualToFieldTestsModel : TestsBaseModel
    {
        [MoreRecentThanOrEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}