using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ContainsAnyTestsModel :  TestsBaseModel
    {
        [ContainsAny("StringToContain", "SecondToContain")]
        public new string FirstField { get; set; }
    }
}