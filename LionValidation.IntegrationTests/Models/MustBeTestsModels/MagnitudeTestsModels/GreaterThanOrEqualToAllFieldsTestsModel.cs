using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanOrEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [GreaterThanOrEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}