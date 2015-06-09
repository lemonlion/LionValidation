using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerThanTestsModel : TestsBaseModel
    {
        [LongerThan(5)]
        public new string FirstField { get; set; }
    }
}