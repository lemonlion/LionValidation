using System.ComponentModel;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfFalseTestsModel :  TestsBaseModel
    {
        [RequiredIfFalse("BooleanOneField")]
        [DisplayName("Required If Boolean one is true")]
        public new string FirstField { get; set; }
    }
}