using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Permissions
    {
        public uint Id { get; set; }
        public uint Admin { get; set; }
        public byte Players { get; set; }
        public byte PlayersMedia { get; set; }
        public byte Sports { get; set; }
        public byte Teams { get; set; }
        public byte Positions { get; set; }
        public byte Schools { get; set; }
        public byte Ranks { get; set; }
        public byte DraftsCreate { get; set; }
        public byte DraftsEdit { get; set; }
        public byte DraftsStage4Edit { get; set; }
        public byte Redrafts { get; set; }
        public byte Posts { get; set; }
        public byte AdminEdit { get; set; }
        public byte UserEdit { get; set; }
        public byte Delete { get; set; }
        public byte Rule { get; set; }
        public byte Ads { get; set; }
        public byte WhatsNew { get; set; }
        public byte Agreement { get; set; }
        public byte DraftsImport { get; set; }
        public string SportAccess { get; set; }
    }
}
