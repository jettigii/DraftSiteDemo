using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSite
{
    public partial class Drafts
    {
        public int Id { get; set; }
        public int Sport { get; set; }
        public string Year { get; set; }
        public DateTime Start { get; set; }
        public byte Monthonly { get; set; }
        public DateTime End { get; set; }
        public string Location { get; set; }
        public ushort Rounddisplay { get; set; }
        public int Playerdisplay { get; set; }
        public byte Tradesuppress { get; set; }
        public byte Status { get; set; }
        public byte Type { get; set; }
        public ushort Compensatory { get; set; }
        public ushort Usermockplayerlimit { get; set; }
        public DateTime Lastupdate { get; set; }
        public bool Displayfreeagents { get; set; }
        public sbyte Livemockstartinground { get; set; }
        public byte TeamOrderChange { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastModifiedBy { get; set; }
        public byte? OpenBy { get; set; }
        public DateTime Time { get; set; }
        public bool ManageDraft { get; set; }
    }
}
