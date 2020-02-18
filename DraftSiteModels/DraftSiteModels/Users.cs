using DraftSiteModels.Entities;
using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Users
    {
        public uint Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Securityphrase { get; set; }
        public string Securityanswer { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public byte Gender { get; set; }
        public string Zip { get; set; }
        public ushort Country { get; set; }
        public string Dob { get; set; }
        public uint Teamnfl { get; set; }
        public uint Teamnba { get; set; }
        public uint Teammlb { get; set; }
        public uint Teamnhl { get; set; }
        public uint Teammls { get; set; }
        public uint Teamwnba { get; set; }
        public string Sportorder { get; set; }
        public byte Maillist { get; set; }
        public DateTime Joindate { get; set; }
        public DateTime Lastlogin { get; set; }
        public bool Featured { get; set; }
        public string Photo { get; set; }
        public string TwitterHandle { get; set; }
        public string FacebookUsername { get; set; }

        public IEnumerable<MultiplayerDraft> MultiPlayerDrafts { get; set; }
        public IEnumerable<DraftTeamUser> DraftTeamUsers { get; set; }        
    }
}
