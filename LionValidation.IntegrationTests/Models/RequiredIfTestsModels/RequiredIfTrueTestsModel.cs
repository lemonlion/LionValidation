using System.ComponentModel;
using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfTrueTestsModel :  TestsBaseModel
    {
        [RequiredIfTrue("BooleanOneField")]
        public new string FirstField { get; set; }
    }
}