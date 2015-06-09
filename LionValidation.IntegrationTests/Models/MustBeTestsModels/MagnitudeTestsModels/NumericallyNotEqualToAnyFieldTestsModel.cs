using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyNotEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [NumericallyNotEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}