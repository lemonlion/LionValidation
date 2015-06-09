using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanAllFieldsTestsModel : TestsBaseModel
    {
        [GreaterThanAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}