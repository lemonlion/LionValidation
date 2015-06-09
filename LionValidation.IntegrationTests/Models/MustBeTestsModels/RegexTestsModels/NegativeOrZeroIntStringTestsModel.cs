using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class NegativeOrZeroIntStringTestsModel : TestsBaseModel
    {
        [NegativeOrZeroInt]
        public new string FirstField { get; set; }
    }
}