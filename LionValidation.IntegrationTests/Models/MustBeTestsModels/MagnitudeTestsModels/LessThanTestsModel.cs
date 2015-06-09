using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanTestsModel : TestsBaseModel
    {
        [LessThan(5)]
        public new string FirstField { get; set; }
    }
}