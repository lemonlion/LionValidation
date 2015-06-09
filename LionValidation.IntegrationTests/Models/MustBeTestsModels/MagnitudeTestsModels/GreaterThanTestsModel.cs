using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanTestsModel : TestsBaseModel
    {
        [GreaterThan(5)]
        public new string FirstField { get; set; }
    }
}