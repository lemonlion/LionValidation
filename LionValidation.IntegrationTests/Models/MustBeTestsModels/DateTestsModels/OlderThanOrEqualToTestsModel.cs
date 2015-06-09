using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanOrEqualToTestsModel : TestsBaseModel
    {
        [OlderThanOrEqualTo("05/01/2014")]
        public new string FirstField { get; set; }
    }
}