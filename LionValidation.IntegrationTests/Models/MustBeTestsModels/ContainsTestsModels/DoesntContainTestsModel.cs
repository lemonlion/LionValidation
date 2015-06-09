using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DoesntContainTestsModel : TestsBaseModel
    {
        [DoesntContain("StringToContain")]
        public new string FirstField { get; set; }
    }
}