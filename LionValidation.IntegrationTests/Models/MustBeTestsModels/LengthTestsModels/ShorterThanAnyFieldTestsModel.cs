using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterThanAnyFieldTestsModel : TestsBaseModel
    {
        [ShorterThanAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}