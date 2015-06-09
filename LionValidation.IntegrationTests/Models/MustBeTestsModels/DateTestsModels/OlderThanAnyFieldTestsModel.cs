using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanAnyFieldTestsModel : TestsBaseModel
    {
        [OlderThanAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}