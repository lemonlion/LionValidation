using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterThanAllFieldsTestsModel : TestsBaseModel
    {
        [ShorterThanAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}