using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class MoneyStringAllowCommasTestsModel : TestsBaseModel
    {
        [MoneyString(Commas.Allow)]
        public new string FirstField { get; set; }
    }
}