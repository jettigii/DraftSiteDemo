using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class UserPlayers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte Approved { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public byte Heightf { get; set; }
        public double Heighti { get; set; }
        public ushort Weight { get; set; }
        public int Sport { get; set; }
        public int Team { get; set; }
        public int Position { get; set; }
        public int School { get; set; }
        public int Country { get; set; }
        public string TwitterHandler { get; set; }
        public int Gradclass { get; set; }
        public int Draftclass { get; set; }
        public int PlayerId { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
