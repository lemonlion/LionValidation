using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterOrLengthEqualToAllFieldsTestsModel : TestsBaseModel
    {
        [ShorterOrLengthEqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}