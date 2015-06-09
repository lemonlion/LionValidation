using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanAllFieldsTestsModel : TestsBaseModel
    {
        [LessThanAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}