using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NegativeIntStringTestsModel : TestsBaseModel
    {
        [NegativeInt]
        public new string FirstField { get; set; }
    }
}