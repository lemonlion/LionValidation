using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterThanTestsModel : TestsBaseModel
    {
        [ShorterThan(5)]
        public new string FirstField { get; set; }
    }
}