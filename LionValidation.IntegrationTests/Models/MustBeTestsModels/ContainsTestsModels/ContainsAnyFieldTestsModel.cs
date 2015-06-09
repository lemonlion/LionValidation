using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ContainsAnyFieldTestsModel :  TestsBaseModel
    {
        [ContainsAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}