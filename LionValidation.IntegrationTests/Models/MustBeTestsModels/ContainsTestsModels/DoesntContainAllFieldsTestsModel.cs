using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DoesntContainAllFieldsTestsModel :  TestsBaseModel
    {
        [DoesntContainAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}