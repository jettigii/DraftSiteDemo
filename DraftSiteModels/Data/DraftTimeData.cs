using DraftSiteModels.Entities;
using System.Collections.Generic;

namespace DraftSiteModels.Data
{
    public static class DraftTimeData
    {
        public static List<DraftTime> DraftTimes = new List<DraftTime>()
        {
            new DraftTime() { Id = 1, Name = "ThirtySeconds", TimeInSeconds = 30, Value = "30 Seconds" },
            new DraftTime() { Id = 2, Name = "OneMinute", TimeInSeconds = 60, Value = "1 Minute" },
            new DraftTime() { Id = 3, Name = "FiveMinutes", TimeInSeconds = 300, Value = "5 Minutes" },
            new DraftTime() { Id = 4, Name = "OneHour", TimeInSeconds = 3600, Value = "1 Hour" },
            new DraftTime() { Id = 5, Name = "Unlimited", TimeInSeconds = 0, Value = "Unlimited" }
        };
    }
}
