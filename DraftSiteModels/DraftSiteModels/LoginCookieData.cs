using System;
using System.ComponentModel.DataAnnotations;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class LoginCookieData
    {
        [Key]
        public int UserId { get; set; }
        public int Series { get; set; }
        public int Token { get; set; }
        public DateTime Expires { get; set; }
        public DateTime LastVerified { get; set; }
    }
}
