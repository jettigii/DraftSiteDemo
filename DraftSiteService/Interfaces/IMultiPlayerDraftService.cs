using System;
using System.Collections.Generic;
using System.Text;

namespace DraftSiteService.Interfaces
{
    public interface IMultiPlayerDraftService
    {
        Action<int> PlayerSelectionBroadcast { get; set; }
    }
}
