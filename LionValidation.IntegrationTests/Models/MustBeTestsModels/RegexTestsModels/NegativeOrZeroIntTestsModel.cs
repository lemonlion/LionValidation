using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NegativeOrZeroIntTestsModel : TestsBaseModel
    {
        [NegativeOrZeroInt]
        public new int? IntField { get; set; }
    }
}