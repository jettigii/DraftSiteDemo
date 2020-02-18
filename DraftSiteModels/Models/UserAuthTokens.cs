using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserAuthTokens
    {
        public int Id { get; set; }
        public string Selector { get; set; }
        public string HashedValidator { get; set; }
        public int UserId { get; set; }
        public DateTime Expires { get; set; }
    }
}
