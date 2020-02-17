﻿using System;
using System.Collections.Generic;

namespace DraftSiteApi.Models
{
    public partial class ResetPassword
    {
        public uint Id { get; set; }
        public uint User { get; set; }
        public string Key { get; set; }
        public bool Used { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
