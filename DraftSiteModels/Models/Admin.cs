using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public DateTime Lastlogin { get; set; }
        public byte Active { get; set; }
        public string Description { get; set; }
        public string TwitterHandler { get; set; }
        public string FacebookUsername { get; set; }
    }
}
