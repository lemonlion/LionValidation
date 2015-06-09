using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class OlderThanFieldTestsModel : TestsBaseModel
    {
        [OlderThanField("SecondField")]
        public new string FirstField { get; set; }
    }
}