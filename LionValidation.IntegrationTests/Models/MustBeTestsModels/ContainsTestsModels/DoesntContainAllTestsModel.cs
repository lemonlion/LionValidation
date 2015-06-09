using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DoesntContainAllTestsModel :  TestsBaseModel
    {
        [DoesntContainAll("StringToContain", "SecondToContain")]
        public new string FirstField { get; set; }
    }
}