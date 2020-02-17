using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Settings
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
