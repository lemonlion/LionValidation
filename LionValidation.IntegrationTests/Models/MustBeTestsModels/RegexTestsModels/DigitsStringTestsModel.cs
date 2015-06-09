using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DigitsStringTestsModel : TestsBaseModel
    {
        [Digits]
        public new string FirstField { get; set; }
    }
}