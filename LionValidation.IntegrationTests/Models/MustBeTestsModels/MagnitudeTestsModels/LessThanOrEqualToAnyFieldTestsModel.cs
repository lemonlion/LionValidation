using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class LessThanOrEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [LessThanOrEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}