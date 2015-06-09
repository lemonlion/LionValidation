using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyEqualToFieldTestsModel : TestsBaseModel
    {
        [NumericallyEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}