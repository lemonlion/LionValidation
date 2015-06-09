using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ContainsTestsModel :  TestsBaseModel
    {
        [Contains("StringToContain")]
        public new string FirstField { get; set; }
    }
}