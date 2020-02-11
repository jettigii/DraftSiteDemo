using DraftSiteModels.Entities;
using System.Collections.Generic;

namespace DraftSiteModels.Data
{
    public static class DraftStatusData
    {
        public static List<DraftStatus> DraftStatuses = new List<DraftStatus>()
        {
            new DraftStatus() { Id = 1, Name = "WaitingForPlayers", Value = "Waiting for players" },
            new DraftStatus() { Id = 2, Name = "WaitingForOwnerToStart", Value = "Waiting for owner" },
            new DraftStatus() { Id = 3, Name = "WaitingForTimerToStart", Value = "Waiting for time" },
            new DraftStatus() { Id = 4, Name = "InProgress", Value = "In Progress" },
            new DraftStatus() { Id = 5, Name = "Paused", Value = "Paused" },
            new DraftStatus() { Id = 6, Name = "Completed", Value = "Completed" },
            new DraftStatus() { Id = 7, Name = "Canceled", Value = "Canceled" }
        };
    }
}
