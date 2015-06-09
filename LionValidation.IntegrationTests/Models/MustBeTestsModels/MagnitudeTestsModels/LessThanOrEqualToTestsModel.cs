using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanOrEqualToTestsModel : TestsBaseModel
    {
        [LessThanOrEqualTo(5)]
        public new string FirstField { get; set; }
    }
}