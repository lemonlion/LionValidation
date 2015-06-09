using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [NumericallyEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}