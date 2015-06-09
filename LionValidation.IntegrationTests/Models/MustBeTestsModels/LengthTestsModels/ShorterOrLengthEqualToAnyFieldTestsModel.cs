using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class ShorterOrLengthEqualToAnyFieldTestsModel : TestsBaseModel
    {
        [ShorterOrLengthEqualToAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}