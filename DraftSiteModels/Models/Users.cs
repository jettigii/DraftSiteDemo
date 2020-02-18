using DraftSiteModels.Entities;
using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Users
    {
        public int Id { get; set; }
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
        public int Teamnfl { get; set; }
        public int Teamnba { get; set; }
        public int Teammlb { get; set; }
        public int Teamnhl { get; set; }
        public int Teammls { get; set; }
        public int Teamwnba { get; set; }
        public string Sportorder { get; set; }
        public byte Maillist { get; set; }
        public DateTime Joindate { get; set; }
        public DateTime Lastlogin { get; set; }
        public bool Featured { get; set; }
        public string Photo { get; set; }
        public string TwitterHandle { get; set; }
        public string FacebookUsername { get; set; }
        public virtual IEnumerable<MultiplayerDraft> MultiPlayerDrafts { get; set; }
        public virtual IEnumerable<DraftUser> DraftUsers { get; set; }        
    }
}
