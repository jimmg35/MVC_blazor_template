using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest.Models
{
    public partial class PdStaticBusLine
    {
        public long Ids { get; set; }
        public string County { get; set; }
        public string Routeuid { get; set; }
        public string Routename { get; set; }
        public string Geometry { get; set; }
    }
}
