using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerThanAllFieldsTestsModel : TestsBaseModel
    {
        [LongerThanAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}