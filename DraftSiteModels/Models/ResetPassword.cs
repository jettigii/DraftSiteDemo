using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class ResetPassword
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Key { get; set; }
        public bool Used { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
