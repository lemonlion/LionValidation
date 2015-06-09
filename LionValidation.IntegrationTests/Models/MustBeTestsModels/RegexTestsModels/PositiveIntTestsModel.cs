using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class PositiveIntTestsModel : TestsBaseModel
    {
        [PositiveInt]
        public new int? IntField { get; set; }
    }
}