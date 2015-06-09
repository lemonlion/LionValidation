using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanOrEqualToTestsModel : TestsBaseModel
    {
        [GreaterThanOrEqualTo(5)]
        public new string FirstField { get; set; }
    }
}