using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Antlr.Runtime;
using LionValidation.Enums;
using LionValidation.ValidationAttributes;

namespace LionValidation.ManualTests.Models
{
    public class BaseModel
    {
        public static Expression<Func<BaseModel, bool>> TestFieldRequiredValidator { get { return x => (x.ValueToTest == "Chocolate" && x.SecondValueToTest == "Cake") || x.ThirdValueToTest == x.FourthValueToTest && ((x.FifthValueToTest / 5) == 4); } }
        public static Expression<Func<BaseModel, bool>> TestFieldRequiredValidator2 { get { return x => x.ValueToTest == "Joe"; } }
        public static Expression<Func<BaseModel, bool>> TestFieldRequiredValidator3 { get { return x => x.SixthValueToTest.ChildField1.GrandChildField1 == true; } }
        
        //[RequiredIf("ValueToTest", Operator.EqualTo, "Chocolate", AndOr.And,
         //           "SecondValueToTest", Operator.EqualTo, "Lemon")]


        //[RequiredIf(Bracket.Open, "ThirdValueToTest", Operator.EqualTo, 5, AndOr.Ɔ_And,
        //                                "FourthValueToTest", Operator.GreaterThan, 6, AndOr.And,
        //                                "FourthValueToTest", Operator.GreaterThan, 6, AndOr.And,
        //                                "FourthValueToTest", Operator.GreaterThan, 6, AddClosingBracket = true,
        //                                ReverseValidationResult = true, ErrorMessage = "Reverse baby")]
        //[RequiredIf("x => x.ValueToTest == 'Chocolate' || (x.ValueToTest == 'Lemon' && x.SecondValueToTest == 'Lemonade')")]
        //[RequiredIf("x => x.ValueToTest == 'Joe2'")]

        //[RequiredIf("TestFieldRequiredValidator", ErrorMessage = "Lambda1")]
        //[RequiredIfLambda("TestFieldRequiredValidator2", ErrorMessage = "Lambda2")]
        //[RequiredIf("TestFieldRequiredValidator3", ErrorMessage = "Lambda3")]
        //[RequiredIf("ValueToTest", Operator.GreaterThan, "5", "10", ErrorMessage = "Normal1")]
        public string TestField { get; set; }

        [MoreRecentThan(DateOf.Today)]
        public string ValueToTest { get; set; }

        //[RequiredIf("SixthValueToTest.ChildField1.TestFieldRequiredValidator4")]
        public string SecondValueToTest { get; set; }

        //[RequiredIf("TestField", Operator.EqualTo, "ads")]
        [MustBe(Operator.EqualTo, "True", AndOr.And_C, "SecondValueToTest", Operator.EqualTo, "True", AndOr.Or, "ValueToTest", Operator.EqualTo, "True", CloseWithBrackets = Bracket.Ɔ)]
        public string ThirdValueToTest { get; set; }
        
        //[DobOlderThan18(DisableClientSideValidation = false)]
        //[Contains("85")]
        public string FourthValueToTest { get; set; }

        //[RequiredIfNot("")]
        public int FifthValueToTest { get; set; }
        
        public BaseModelChild SixthValueToTest { get; set; }
    }

    public class BaseModelChild
    {
        public BaseModelGrandChild ChildField1 { get; set; }
    }

    public class BaseModelGrandChild
    {
        //[RequiredIf("GrandChildField2", Operator.EqualTo, true)]
        public bool? GrandChildField1 { get; set; }

        public bool GrandChildField2 { get; set; }

        public static Expression<Func<BaseModel, bool>> TestFieldRequiredValidator4 { get { return x => x.ValueToTest == "Mary"; } }
    }
}