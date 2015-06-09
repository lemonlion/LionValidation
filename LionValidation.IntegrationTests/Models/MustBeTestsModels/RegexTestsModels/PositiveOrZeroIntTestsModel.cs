using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class PositiveOrZeroIntTestsModel : TestsBaseModel
    {
        [PositiveOrZeroInt]
        public new int? IntField { get; set; }
    }
}