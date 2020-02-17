using System;

namespace DraftSiteModels.DraftSite
{
    public partial class AdminAuthTokens
    {
        public uint Id { get; set; }
        public string Selector { get; set; }
        public string HashedValidator { get; set; }
        public uint AdminId { get; set; }
        public DateTime Expires { get; set; }
    }
}
