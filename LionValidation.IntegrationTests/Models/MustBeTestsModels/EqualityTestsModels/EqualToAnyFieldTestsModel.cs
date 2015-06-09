using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class EqualToAnyFieldTestsModel : TestsBaseModel
    {
        [EqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}