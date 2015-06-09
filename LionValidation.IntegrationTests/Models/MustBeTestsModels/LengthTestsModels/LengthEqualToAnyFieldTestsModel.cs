using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LengthEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [LengthEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}