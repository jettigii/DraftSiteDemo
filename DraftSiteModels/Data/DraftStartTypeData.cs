using DraftSiteModels.Entities;
using System.Collections.Generic;

namespace DraftSiteModels.Data
{
    public static class DraftStartTypeData
    {
        public static List<DraftStartType> DraftStartTypes = new List<DraftStartType>()
        {
            new DraftStartType() { Id = 1, Name = "Manual", Value = "Manual", IsEnabled = true },
            new DraftStartType() { Id = 2, Name = "Automatic", Value = "Automatic", IsEnabled = false },
        };
    }
}
