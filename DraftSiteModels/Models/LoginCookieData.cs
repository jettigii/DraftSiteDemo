using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class LoginCookieData
    {
        public int UserId { get; set; }
        public int Series { get; set; }
        public int Token { get; set; }
        public DateTime Expires { get; set; }
        public DateTime LastVerified { get; set; }
    }
}
