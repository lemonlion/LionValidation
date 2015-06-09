using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanOrEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [OlderThanOrEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}