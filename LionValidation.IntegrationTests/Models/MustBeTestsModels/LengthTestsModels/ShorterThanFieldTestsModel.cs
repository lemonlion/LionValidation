using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterThanFieldTestsModel : TestsBaseModel
    {
        [ShorterThanField("SecondField")]
        public new string FirstField { get; set; }
    }
}