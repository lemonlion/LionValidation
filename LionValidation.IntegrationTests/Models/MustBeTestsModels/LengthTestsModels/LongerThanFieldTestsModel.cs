using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerThanFieldTestsModel : TestsBaseModel
    {
        [LongerThanField("SecondField")]
        public new string FirstField { get; set; }
    }
}