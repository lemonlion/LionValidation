using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NumericallyEqualToAnyTestsModel : TestsBaseModel
    {
        [NumericallyEqualToAny(5, 10)]
        public new string FirstField { get; set; }
    }
}