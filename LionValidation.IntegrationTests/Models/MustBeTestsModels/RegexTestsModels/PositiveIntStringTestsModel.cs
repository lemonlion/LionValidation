using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class PositiveIntStringTestsModel : TestsBaseModel
    {
        [PositiveInt]
        public new string FirstField { get; set; }
    }
}