using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DoesntContainAnyTestsModel :  TestsBaseModel
    {
        [DoesntContainAny("StringToContain", "SecondToContain")]
        public new string FirstField { get; set; }
    }
}