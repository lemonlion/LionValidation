using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class EqualToFieldTestsModel : TestsBaseModel
    {
        [EqualToField("SecondField")]
        public new string FirstField { get; set; }
    }
}