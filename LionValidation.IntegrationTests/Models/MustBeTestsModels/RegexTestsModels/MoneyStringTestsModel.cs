using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoneyStringTestsModel : TestsBaseModel
    {
        [MoneyString]
        public new string FirstField { get; set; }
    }
}