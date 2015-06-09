using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyEqualToTestsModel : TestsBaseModel
    {
        [NumericallyEqualTo(5)]
        public new string FirstField { get; set; }
    }
}