using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class Tradetransactions
    {
        public uint Id { get; set; }
        public uint Trade { get; set; }
        public uint Round { get; set; }
        public string Futuredraft { get; set; }
        public string Player { get; set; }
        public string PlayersTo { get; set; }
        public uint Fromoriginal { get; set; }
        public uint From { get; set; }
        public uint To { get; set; }
        public byte Check { get; set; }
        public byte Type { get; set; }
        public byte Picktype { get; set; }
        public byte Specialpickinstance { get; set; }
    }
}
