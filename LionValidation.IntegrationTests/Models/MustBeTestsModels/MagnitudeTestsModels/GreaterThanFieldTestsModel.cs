using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class GreaterThanFieldTestsModel : TestsBaseModel
    {
        [GreaterThanField("SecondField")]
        public new string FirstField { get; set; }
    }
}