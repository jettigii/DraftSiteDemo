using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserAuthTokens
    {
        public uint Id { get; set; }
        public string Selector { get; set; }
        public string HashedValidator { get; set; }
        public uint UserId { get; set; }
        public DateTime Expires { get; set; }
    }
}
