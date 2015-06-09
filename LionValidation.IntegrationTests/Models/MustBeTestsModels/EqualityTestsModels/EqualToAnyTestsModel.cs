using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class EqualToAnyTestsModel : TestsBaseModel
    {
        [EqualToAny("TestData", "TestData2")]
        public new string FirstField { get; set; }
    }
}