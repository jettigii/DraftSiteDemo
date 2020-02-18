using DraftSiteModels.Entities;
using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Players
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public byte Status { get; set; }
        public DateTime? Dob { get; set; }
        public string Age { get; set; }
        public byte Heightf { get; set; }
        public double Heighti { get; set; }
        public ushort Weight { get; set; }
        public int Sport { get; set; }
        public int Team { get; set; }
        public int Position { get; set; }
        public int Preposition { get; set; }
        public int? Preteam { get; set; }
        public int? School { get; set; }
        public int Preschool { get; set; }
        public int Highschool { get; set; }
        public int Prehighschool { get; set; }
        public int Country { get; set; }
        public string Gradclass { get; set; }
        public string Draftclass { get; set; }
        public byte Bats { get; set; }
        public byte Throws { get; set; }
        public byte Shoots { get; set; }
        public byte[] Commentary { get; set; }
        public byte[] Stats { get; set; }
        public byte[] Notes { get; set; }
        public string TwitterHandler { get; set; }
        public int? PlayerComparison { get; set; }
        public byte Redshirt { get; set; }
        public sbyte? Fantasy { get; set; }
        public int? FantasyTeam { get; set; }
        public string FantasyPositions { get; set; }
        public DateTime Lastupdate { get; set; }
        public DateTime? Lastactivity { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public IEnumerable<DraftTeamUserPlayer> DraftTeamUserPlayers { get; set; }
    }
}
