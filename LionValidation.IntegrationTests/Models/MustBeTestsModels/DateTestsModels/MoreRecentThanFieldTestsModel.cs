using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoreRecentThanFieldTestsModel : TestsBaseModel
    {
        [MoreRecentThanField("SecondField")]
        public new string FirstField { get; set; }
    }
}