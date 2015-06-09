using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyNotEqualToTestsModel : TestsBaseModel
    {
        [NumericallyNotEqualTo(5)]
        public new string FirstField { get; set; }
    }
}