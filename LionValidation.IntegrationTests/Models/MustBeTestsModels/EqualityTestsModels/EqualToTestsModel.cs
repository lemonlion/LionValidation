using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class EqualToTestsModel : TestsBaseModel
    {
        [EqualTo("TestData")]
        public new string FirstField { get; set; }
    }
}