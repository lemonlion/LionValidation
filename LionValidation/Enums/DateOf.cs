using System.ComponentModel;

namespace LionValidation.Enums
{
    public enum DateOf
    {
        Today,
        Tomorrow,
        Yesterday,

        [Description("One Month From Now")]
        OneMonthFromNow,
        [Description("Two Months From Now")]
        TwoMonthsFromNow,
        [Description("Three Months From Now")]
        ThreeMonthsFromNow,
        [Description("Four Months From Now")]
        FourMonthsFromNow,
        [Description("Five Months From Now")]
        FiveMonthsFromNow,
        [Description("Six Months From Now")]
        SixMonthsFromNow,
        [Description("Seven Months From Now")]
        SevenMonthsFromNow,
        [Description("Eight Months From Now")]
        EightMonthsFromNow,
        [Description("Nine Months From Now")]
        NineMonthsFromNow,
        [Description("Ten Months From Now")]
        TenMonthsFromNow,
        [Description("Eleven Months From Now")]
        ElevenMonthsFromNow,
        [Description("Twelve Months From Now")]
        TwelveMonthsFromNow,
        [Description("Thirteen Months From Now")]
        ThirteenMonthsFromNow,
        [Description("Fourteen Months From Now")]
        FourteenMonthsFromNow,
        [Description("Fifteen Months From Now")]
        FifteenMonthsFromNow,
        [Description("Sixteen Months From Now")]
        SixteenMonthsFromNow,
        [Description("Seventeen Months From Now")]
        SeventeenMonthsFromNow,
        [Description("Eighteen Months From Now")]
        EighteenMonthsFromNow,
        [Description("Twenty One Months From Now")]
        TwentyOneMonthsFromNow,

        [Description("One Month Ago")]
        OneMonthAgo,
        [Description("Two Months Ago")]
        TwoMonthsAgo,
        [Description("Three Months Ago")]
        ThreeMonthsAgo,
        [Description("Four Months Ago")]
        FourMonthsAgo,
        [Description("Five Months Ago")]
        FiveMonthsAgo,
        [Description("Six Months Ago")]
        SixMonthsAgo,
        [Description("Seven Months Ago")]
        SevenMonthsAgo,
        [Description("Eight Months Ago")]
        EightMonthsAgo,
        [Description("Nine Months Ago")]
        NineMonthsAgo,
        [Description("Ten Months Ago")]
        TenMonthsAgo,
        [Description("Eleven Months Ago")]
        ElevenMonthsAgo,
        [Description("Twelve Months Ago")]
        TwelveMonthsAgo,
        [Description("Thirteen Months Ago")]
        ThirteenMonthsAgo,
        [Description("Fourteen Months Ago")]
        FourteenMonthsAgo,
        [Description("Fifteen Months Ago")]
        FifteenMonthsAgo,
        [Description("Sixteen Months Ago")]
        SixteenMonthsAgo,
        [Description("Seventeen Months Ago")]
        SeventeenMonthsAgo,
        [Description("Eighteen Months Ago")]
        EighteenMonthsAgo,
        [Description("Twenty One Months Ago")]
        TwentyOneMonthsAgo,

        [Description("One Year From Now")]
        OneYearFromNow,
        [Description("Two Years From Now")]
        TwoYearsFromNow,
        [Description("Three Years From Now")]
        ThreeYearsFromNow,
        [Description("Four Years From Now")]
        FourYearsFromNow,
        [Description("Five Years From Now")]
        FiveYearsFromNow,
        [Description("Six Years From Now")]
        SixYearsFromNow,
        [Description("Seven Years From Now")]
        SevenYearsFromNow,
        [Description("Eight Years From Now")]
        EightYearsFromNow,
        [Description("Nine Years From Now")]
        NineYearsFromNow,
        [Description("Ten Years From Now")]
        TenYearsFromNow,
        [Description("Eleven Years From Now")]
        ElevenYearsFromNow,
        [Description("Twelve Years From Now")]
        TwelveYearsFromNow,
        [Description("Thirteen Years From Now")]
        ThirteenYearsFromNow,
        [Description("Fourteen Years From Now")]
        FourteenYearsFromNow,
        [Description("Fifteen Years From Now")]
        FifteenYearsFromNow,
        [Description("Sixteen Years From Now")]
        SixteenYearsFromNow,
        [Description("Seventeen Years From Now")]
        SeventeenYearsFromNow,
        [Description("Eighteen Years From Now")]
        EighteenYearsFromNow,
        [Description("Nineteen Years From Now")]
        NineteenYearsFromNow,
        [Description("Twenty Years From Now")]
        TwentyYearsFromNow,
        [Description("Twenty One Years From Now")]
        TwentyOneYearsFromNow,
        [Description("Twenty Two Years From Now")]
        TwentyTwoYearsFromNow,
        [Description("Twenty Three Years From Now")]
        TwentyThreeYearsFromNow,
        [Description("Twenty Four Years From Now")]
        TwentyFourYearsFromNow,
        [Description("Twenty Five Years From Now")]
        TwentyFiveYearsFromNow,

        [Description("One Year Ago")]
        OneYearAgo,
        [Description("Two Years Ago")]
        TwoYearsAgo,
        [Description("Three Years Ago")]
        ThreeYearsAgo,
        [Description("Four Years Ago")]
        FourYearsAgo,
        [Description("Five Years Ago")]
        FiveYearsAgo,
        [Description("Six Years Ago")]
        SixYearsAgo,
        [Description("Seven Years Ago")]
        SevenYearsAgo,
        [Description("Eight Years Ago")]
        EightYearsAgo,
        [Description("Nine Years Ago")]
        NineYearsAgo,
        [Description("Ten Years Ago")]
        TenYearsAgo,
        [Description("Eleven Years Ago")]
        ElevenYearsAgo,
        [Description("Twelve Years Ago")]
        TwelveYearsAgo,
        [Description("Thirteen Years Ago")]
        ThirteenYearsAgo,
        [Description("Fourteen Years Ago")]
        FourteenYearsAgo,
        [Description("Fifteen Years Ago")]
        FifteenYearsAgo,
        [Description("Sixteen Years Ago")]
        SixteenYearsAgo,
        [Description("Seventeen Years Ago")]
        SeventeenYearsAgo,
        [Description("Eighteen Years Ago")]
        EighteenYearsAgo,
        [Description("Nineteen Years Ago")]
        NineteenYearsAgo,
        [Description("Twenty Years Ago")]
        TwentyYearsAgo,
        [Description("Twenty One Years Ago")]
        TwentyOneYearsAgo,
        [Description("Twenty Two Years Ago")]
        TwentyTwoYearsAgo,
        [Description("Twenty Three Years Ago")]
        TwentyThreeYearsAgo,
        [Description("Twenty Four Years Ago")]
        TwentyFourYearsAgo,
        [Description("Twenty Five Years Ago")]
        TwentyFiveYearsAgo,

        [Description("One Day From Now")]
        OneDayFromNow,
        [Description("Two Days From Now")]
        TwoDaysFromNow,
        [Description("Three Days From Now")]
        ThreeDaysFromNow,
        [Description("Four Days From Now")]
        FourDaysFromNow,
        [Description("Five Days From Now")]
        FiveDaysFromNow,
        [Description("Six Days From Now")]
        SixDaysFromNow,
        [Description("Seven Days From Now")]
        SevenDaysFromNow,
        [Description("Eight Days From Now")]
        EightDaysFromNow,
        [Description("Nine Days From Now")]
        NineDaysFromNow,
        [Description("Ten Days From Now")]
        TenDaysFromNow,
        [Description("Eleven Days From Now")]
        ElevenDaysFromNow,
        [Description("Twelve Days From Now")]
        TwelveDaysFromNow,
        [Description("Thirteen Days From Now")]
        ThirteenDaysFromNow,
        [Description("Fourteen Days From Now")]
        FourteenDaysFromNow,
        [Description("Fifteen Days From Now")]
        FifteenDaysFromNow,
        [Description("Sixteen Days From Now")]
        SixteenDaysFromNow,
        [Description("Seventeen Days From Now")]
        SeventeenDaysFromNow,
        [Description("Eighteen Days From Now")]
        EighteenDaysFromNow,
        [Description("Nineteen Days From Now")]
        NineteenDaysFromNow,
        [Description("Twenty Days From Now")]
        TwentyDaysFromNow,
        [Description("Twenty One Days From Now")]
        TwentyOneDaysFromNow,
        [Description("Twenty Two Days From Now")]
        TwentyTwoDaysFromNow,
        [Description("Twenty Three Days From Now")]
        TwentyThreeDaysFromNow,
        [Description("Twenty Four Days From Now")]
        TwentyFourDaysFromNow,
        [Description("Twenty Five Days From Now")]
        TwentyFiveDaysFromNow,
        [Description("Twenty Six Days From Now")]
        TwentySixDaysFromNow,
        [Description("Twenty Seven Days From Now")]
        TwentySevenDaysFromNow,
        [Description("Twenty Eight Days From Now")]
        TwentyEightDaysFromNow,
        [Description("Twenty Nine Days From Now")]
        TwentyNineDaysFromNow,
        [Description("Thirty Days From Now")]
        ThirtyDaysFromNow,
        [Description("Thirty One Days From Now")]
        ThirtyOneDaysFromNow,
        [Description("Thirty Two Days From Now")]
        ThirtyTwoDaysFromNow,
        [Description("Thirty Three Days From Now")]
        ThirtyThreeDaysFromNow,
        [Description("Thirty Four Days From Now")]
        ThirtyFourDaysFromNow,
        [Description("Thirty Five Days From Now")]
        ThirtyFiveDaysFromNow,
        [Description("Thirty Six Days From Now")]
        ThirtySixDaysFromNow,
        [Description("Thirty Seven Days From Now")]
        ThirtySevenDaysFromNow,
        [Description("Thirty Eight Days From Now")]
        ThirtyEightDaysFromNow,
        [Description("Thirty Nine Days From Now")]
        ThirtyNineDaysFromNow,
        [Description("Forty Days From Now")]
        FortyDaysFromNow,
        [Description("Forty One Days From Now")]
        FortyOneDaysFromNow,
        [Description("Forty Two Days From Now")]
        FortyTwoDaysFromNow,
        [Description("Forty Three Days From Now")]
        FortyThreeDaysFromNow,
        [Description("Forty Four Days From Now")]
        FortyFourDaysFromNow,
        [Description("FortyFiveDaysFromNow")]
        FortyFiveDaysFromNow,
        [Description("Forty Six Days From Now")]
        FortySixDaysFromNow,
        [Description("Forty Seven Days From Now")]
        FortySevenDaysFromNow,
        [Description("Forty Eight Days From Now")]
        FortyEightDaysFromNow,
        [Description("Forty Nine Days From Now")]
        FortyNineDaysFromNow,
        [Description("Fifty Days From Now")]
        FiftyDaysFromNow,
        [Description("Fifty One Days From Now")]
        FiftyOneDaysFromNow,
        [Description("Fifty Two Days From Now")]
        FiftyTwoDaysFromNow,
        [Description("Fifty Three Days From Now")]
        FiftyThreeDaysFromNow,
        [Description("Fifty Four Days From Now")]
        FiftyFourDaysFromNow,
        [Description("Fifty Five Days From Now")]
        FiftyFiveDaysFromNow,
        [Description("Fifty Six Days From Now")]
        FiftySixDaysFromNow,
        [Description("Fifty Seven Days From Now")]
        FiftySevenDaysFromNow,
        [Description("Fifty Eight Days From Now")]
        FiftyEightDaysFromNow,
        [Description("Fifty Nine Days From Now")]
        FiftyNineDaysFromNow,
        [Description("Sixty Days From Now")]
        SixtyDaysFromNow,

        [Description("One Day Ago")]
        OneDayAgo,
        [Description("Two Days Ago")]
        TwoDaysAgo,
        [Description("Three Days Ago")]
        ThreeDaysAgo,
        [Description("Four Days Ago")]
        FourDaysAgo,
        [Description("Five Days Ago")]
        FiveDaysAgo,
        [Description("Six Days Ago")]
        SixDaysAgo,
        [Description("Seven Days Ago")]
        SevenDaysAgo,
        [Description("Eight Days Ago")]
        EightDaysAgo,
        [Description("Nine Days Ago")]
        NineDaysAgo,
        [Description("Ten Days Ago")]
        TenDaysAgo,
        [Description("Eleven Days Ago")]
        ElevenDaysAgo,
        [Description("Twelve Days Ago")]
        TwelveDaysAgo,
        [Description("Thirteen Days Ago")]
        ThirteenDaysAgo,
        [Description("Fourteen Days Ago")]
        FourteenDaysAgo,
        [Description("Fifteen Days Ago")]
        FifteenDaysAgo,
        [Description("Sixteen Days Ago")]
        SixteenDaysAgo,
        [Description("Seventeen Days Ago")]
        SeventeenDaysAgo,
        [Description("Eighteen Days Ago")]
        EighteenDaysAgo,
        [Description("Nineteen Days Ago")]
        NineteenDaysAgo,
        [Description("Twenty Days Ago")]
        TwentyDaysAgo,
        [Description("Twenty One Days Ago")]
        TwentyOneDaysAgo,
        [Description("Twenty Two Days Ago")]
        TwentyTwoDaysAgo,
        [Description("Twenty Three Days Ago")]
        TwentyThreeDaysAgo,
        [Description("Twenty Four Days Ago")]
        TwentyFourDaysAgo,
        [Description("Twenty Five Days Ago")]
        TwentyFiveDaysAgo,
        [Description("Twenty Six Days Ago")]
        TwentySixDaysAgo,
        [Description("Twenty Seven Days Ago")]
        TwentySevenDaysAgo,
        [Description("Twenty Eight Days Ago")]
        TwentyEightDaysAgo,
        [Description("Twenty Nine Days Ago")]
        TwentyNineDaysAgo,
        [Description("Thirty Days Ago")]
        ThirtyDaysAgo,
        [Description("Thirty One Days Ago")]
        ThirtyOneDaysAgo,
        [Description("Thirty Two Days Ago")]
        ThirtyTwoDaysAgo,
        [Description("Thirty Three Days Ago")]
        ThirtyThreeDaysAgo,
        [Description("Thirty Four Days Ago")]
        ThirtyFourDaysAgo,
        [Description("Thirty Five Days Ago")]
        ThirtyFiveDaysAgo,
        [Description("Thirty Six Days Ago")]
        ThirtySixDaysAgo,
        [Description("Thirty Seven Days Ago")]
        ThirtySevenDaysAgo,
        [Description("Thirty Eight Days Ago")]
        ThirtyEightDaysAgo,
        [Description("Thirty Nine Days Ago")]
        ThirtyNineDaysAgo,
        [Description("Forty Days Ago")]
        FortyDaysAgo,
        [Description("Forty One Days Ago")]
        FortyOneDaysAgo,
        [Description("Forty Two Days Ago")]
        FortyTwoDaysAgo,
        [Description("Forty Three Days Ago")]
        FortyThreeDaysAgo,
        [Description("Forty Four Days Ago")]
        FortyFourDaysAgo,
        [Description("FortyFiveDaysAgo")]
        FortyFiveDaysAgo,
        [Description("Forty Six Days Ago")]
        FortySixDaysAgo,
        [Description("Forty Seven Days Ago")]
        FortySevenDaysAgo,
        [Description("Forty Eight Days Ago")]
        FortyEightDaysAgo,
        [Description("Forty Nine Days Ago")]
        FortyNineDaysAgo,
        [Description("Fifty Days Ago")]
        FiftyDaysAgo,
        [Description("Fifty One Days Ago")]
        FiftyOneDaysAgo,
        [Description("Fifty Two Days Ago")]
        FiftyTwoDaysAgo,
        [Description("Fifty Three Days Ago")]
        FiftyThreeDaysAgo,
        [Description("Fifty Four Days Ago")]
        FiftyFourDaysAgo,
        [Description("Fifty Five Days Ago")]
        FiftyFiveDaysAgo,
        [Description("Fifty Six Days Ago")]
        FiftySixDaysAgo,
        [Description("Fifty Seven Days Ago")]
        FiftySevenDaysAgo,
        [Description("Fifty Eight Days Ago")]
        FiftyEightDaysAgo,
        [Description("Fifty Nine Days Ago")]
        FiftyNineDaysAgo,
        [Description("Sixty Days Ago")]
        SixtyDaysAgo,
    }
}