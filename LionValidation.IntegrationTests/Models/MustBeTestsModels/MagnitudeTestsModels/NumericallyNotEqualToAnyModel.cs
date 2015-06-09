using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyNotEqualToAnyTestsModel : TestsBaseModel
    {
        [NumericallyNotEqualToAny(5, 10)]
        public new string FirstField { get; set; }
    }
}