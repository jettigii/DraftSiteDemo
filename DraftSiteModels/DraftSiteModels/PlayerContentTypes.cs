using System;
using System.Collections.Generic;

namespace DraftSiteModels.DraftSiteModels
{
    public partial class PlayerContentTypes
    {
        public sbyte Id { get; set; }
        public string Name { get; set; }
        public sbyte PlayerLimit { get; set; }
        public sbyte UserLimit { get; set; }
        public string Column { get; set; }
        public bool? ShowName { get; set; }
    }
}
