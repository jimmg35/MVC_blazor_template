using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest
{
    public partial class PdStaticBikeStopdetail
    {
        public long Ids { get; set; }
        public string Stationuid { get; set; }
        public string County { get; set; }
        public string Stationnamezh { get; set; }
        public string Stationnameeng { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
    }
}
