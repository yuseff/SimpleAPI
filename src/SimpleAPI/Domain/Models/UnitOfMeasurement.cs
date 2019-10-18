using System.ComponentModel;

namespace SimpleAPI.Domain.Models
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("HR")]
        Homerun = 1,

        [Description("ERA")]
        ERA = 2,

        [Description("AVG")]
        BattingAverage = 3,

        [Description("TD")]
        Touchdown = 4,

        [Description("G")]
        Goal = 5,

        [Description("PTS")]
        Points = 6
    }
}