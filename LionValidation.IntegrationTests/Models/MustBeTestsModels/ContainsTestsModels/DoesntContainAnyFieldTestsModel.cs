using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class DoesntContainAnyFieldTestsModel :  TestsBaseModel
    {
        [DoesntContainAnyField("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}