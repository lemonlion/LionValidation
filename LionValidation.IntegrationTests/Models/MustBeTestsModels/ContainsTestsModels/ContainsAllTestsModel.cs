using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ContainsAllTestsModel :  TestsBaseModel
    {
        [ContainsAll("StringToContain", "SecondToContain")]
        public new string FirstField { get; set; }
    }
}