﻿using LionValidation.ValidationAttributes;

namespace LionValidation.IntegrationTests.Models
{
    public class RequiredIfAnyEmptyTestsModel :  TestsBaseModel
    {
        [RequiredIfAnyEmpty("SecondField", "ThirdField")]
        public new string FirstField { get; set; }
    }
}