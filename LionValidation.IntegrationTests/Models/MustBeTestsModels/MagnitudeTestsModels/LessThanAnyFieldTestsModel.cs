using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanAnyFieldTestsModel : TestsBaseModel
    {
        [LessThanAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}