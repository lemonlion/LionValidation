using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LongerThanAnyFieldTestsModel : TestsBaseModel
    {
        [LongerThanAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}