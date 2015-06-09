using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanOrEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [OlderThanOrEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}