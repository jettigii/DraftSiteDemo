using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class UserPlayers
    {
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public byte Approved { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public byte Heightf { get; set; }
        public double Heighti { get; set; }
        public ushort Weight { get; set; }
        public uint Sport { get; set; }
        public uint Team { get; set; }
        public uint Position { get; set; }
        public uint School { get; set; }
        public uint Country { get; set; }
        public string TwitterHandler { get; set; }
        public uint Gradclass { get; set; }
        public uint Draftclass { get; set; }
        public uint PlayerId { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
