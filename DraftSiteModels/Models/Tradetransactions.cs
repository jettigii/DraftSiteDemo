using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Tradetransactions
    {
        public int Id { get; set; }
        public int Trade { get; set; }
        public int Round { get; set; }
        public string Futuredraft { get; set; }
        public string Player { get; set; }
        public string PlayersTo { get; set; }
        public int Fromoriginal { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public byte Check { get; set; }
        public byte Type { get; set; }
        public byte Picktype { get; set; }
        public byte Specialpickinstance { get; set; }
    }
}
