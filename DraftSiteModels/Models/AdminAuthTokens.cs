using System;

namespace DraftSiteModels.DraftSite
{
    public partial class AdminAuthTokens
    {
        public int Id { get; set; }
        public string Selector { get; set; }
        public string HashedValidator { get; set; }
        public int AdminId { get; set; }
        public DateTime Expires { get; set; }
    }
}
