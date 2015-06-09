using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ContainsAllFieldsTestsModel :  TestsBaseModel
    {
        [ContainsAllFields("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}