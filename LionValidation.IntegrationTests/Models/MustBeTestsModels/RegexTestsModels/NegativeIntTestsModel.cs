using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NegativeIntTestsModel : TestsBaseModel
    {
        [NegativeInt]
        public new int? IntField { get; set; }
    }
}