using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest
{
    public partial class PdStaticBusRoutedetail
    {
        public long Ids { get; set; }
        public string Routeuid { get; set; }
        public string County { get; set; }
        public string Routename { get; set; }
        public string Stopuid { get; set; }
        public string Stopsequence { get; set; }
        public int? Direction { get; set; }
        public string Stopname { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}
