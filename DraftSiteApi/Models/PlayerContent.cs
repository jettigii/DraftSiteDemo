using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class PlayerContent
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public sbyte TypeId { get; set; }
        public string Data { get; set; }
        public bool Approved { get; set; }
        public int UserId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
