using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LengthEqualToTestsModel : TestsBaseModel
    {
        [LengthEqualTo(5)]
        public new string FirstField { get; set; }
    }
}