using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [NumericallyEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}