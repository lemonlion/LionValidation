using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanFieldTestsModel : TestsBaseModel
    {
        [LessThanField("SecondField")]
        public new string FirstField { get; set; }
    }
}