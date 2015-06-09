using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanOrEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [GreaterThanOrEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}