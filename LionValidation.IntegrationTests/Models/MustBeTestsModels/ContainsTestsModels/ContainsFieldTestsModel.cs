using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ContainsFieldTestsModel :  TestsBaseModel
    {
        [ContainsField("SecondField")]
        public new string FirstField { get; set; }
    }
}