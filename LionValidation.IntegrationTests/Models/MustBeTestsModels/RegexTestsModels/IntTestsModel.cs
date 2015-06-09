using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class IntTestsModel : TestsBaseModel
    {
        [Int]
        public new int? IntField { get; set; }
    }
}