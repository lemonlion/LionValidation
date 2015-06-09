using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterOrLengthEqualToTestsModel : TestsBaseModel
    {
        [ShorterOrLengthEqualTo(5)]
        public new string FirstField { get; set; }
    }
}