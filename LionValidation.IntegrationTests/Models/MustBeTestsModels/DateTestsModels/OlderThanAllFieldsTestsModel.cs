using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanAllFieldsTestsModel : TestsBaseModel
    {
        [OlderThanAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}