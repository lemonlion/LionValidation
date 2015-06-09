using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyNotEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [NumericallyNotEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}