using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class PositiveOrZeroIntStringTestsModel : TestsBaseModel
    {
        [PositiveOrZeroInt]
        public new string FirstField { get; set; }
    }
}