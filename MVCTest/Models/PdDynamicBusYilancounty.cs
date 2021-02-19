using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest
{
    public partial class PdDynamicBusYilancounty
    {
        public long Id { get; set; }
        public string Routeuid { get; set; }
        public string Platenumb { get; set; }
        public int? Direction { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Azimuth { get; set; }
        public int? Busstatus { get; set; }
        public string Updatetime { get; set; }
    }
}
