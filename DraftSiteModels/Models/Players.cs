using DraftSiteModels.Entities;
using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Players
    {
        public uint Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public byte Status { get; set; }
        public DateTime? Dob { get; set; }
        public string Age { get; set; }
        public byte Heightf { get; set; }
        public double Heighti { get; set; }
        public ushort Weight { get; set; }
        public uint Sport { get; set; }
        public uint Team { get; set; }
        public uint Position { get; set; }
        public uint Preposition { get; set; }
        public uint? Preteam { get; set; }
        public uint? School { get; set; }
        public uint Preschool { get; set; }
        public uint Highschool { get; set; }
        public uint Prehighschool { get; set; }
        public uint Country { get; set; }
        public string Gradclass { get; set; }
        public string Draftclass { get; set; }
        public byte Bats { get; set; }
        public byte Throws { get; set; }
        public byte Shoots { get; set; }
        public byte[] Commentary { get; set; }
        public byte[] Stats { get; set; }
        public byte[] Notes { get; set; }
        public string TwitterHandler { get; set; }
        public uint? PlayerComparison { get; set; }
        public byte Redshirt { get; set; }
        public sbyte? Fantasy { get; set; }
        public int? FantasyTeam { get; set; }
        public string FantasyPositions { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? Lastactivity { get; set; }
        public uint? CreatedBy { get; set; }
        public uint? LastModifiedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public IEnumerable<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }
    }
}
