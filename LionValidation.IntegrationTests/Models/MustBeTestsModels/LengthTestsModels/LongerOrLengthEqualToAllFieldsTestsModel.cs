using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerOrLengthEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [LongerOrLengthEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}