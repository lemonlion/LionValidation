using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class IntStringTestsModel : TestsBaseModel
    {
        [Int]
        public new string FirstField { get; set; }
    }
}