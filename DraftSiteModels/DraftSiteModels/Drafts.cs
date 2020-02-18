using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class Drafts
    {
        public uint Id { get; set; }
        public uint Sport { get; set; }
        public string Year { get; set; }
        public DateTime Start { get; set; }
        public byte Monthonly { get; set; }
        public DateTime End { get; set; }
        public string Location { get; set; }
        public ushort Rounddisplay { get; set; }
        public uint Playerdisplay { get; set; }
        public byte Tradesuppress { get; set; }
        public byte Status { get; set; }
        public byte Type { get; set; }
        public ushort Compensatory { get; set; }
        public ushort Usermockplayerlimit { get; set; }
        public DateTime Lastupdate { get; set; }
        public bool Displayfreeagents { get; set; }
        public sbyte Livemockstartinground { get; set; }
        public byte TeamOrderChange { get; set; }
        public uint? CreatedBy { get; set; }
        public uint? LastModifiedBy { get; set; }
        public byte? OpenBy { get; set; }
        public DateTime Time { get; set; }
        public bool ManageDraft { get; set; }
    }
}
