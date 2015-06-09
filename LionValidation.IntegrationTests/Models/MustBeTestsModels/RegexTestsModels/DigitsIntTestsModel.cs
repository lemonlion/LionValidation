using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DigitsIntTestsModel : TestsBaseModel
    {
        [Digits]
        public new int? IntField { get; set; }
    }
}