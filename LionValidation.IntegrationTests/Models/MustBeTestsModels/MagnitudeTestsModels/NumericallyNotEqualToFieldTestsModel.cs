using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyNotEqualToFieldTestsModel : TestsBaseModel
    {
        [NumericallyNotEqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}