using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerOrLengthEqualToTestsModel : TestsBaseModel
    {
        [LongerOrLengthEqualTo(5)]
        public new string FirstField { get; set; }
    }
}