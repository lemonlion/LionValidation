using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerOrLengthEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [LongerOrLengthEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}