using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class EqualToAllFieldsTestsModel : TestsBaseModel
    {
        [EqualToAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}