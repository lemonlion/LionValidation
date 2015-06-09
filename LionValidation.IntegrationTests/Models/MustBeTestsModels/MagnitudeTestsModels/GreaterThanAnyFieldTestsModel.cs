using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanAnyFieldTestsModel : TestsBaseModel
    {
        [GreaterThanAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}