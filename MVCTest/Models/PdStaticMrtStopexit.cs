using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest
{
    public partial class PdStaticMrtStopexit
    {
        public long Ids { get; set; }
        public string County { get; set; }
        public string Stationid { get; set; }
        public string Exitid { get; set; }
        public string Exitnamezh { get; set; }
        public string Exitnameeng { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Description { get; set; }
        public string Escalator { get; set; }
        public bool? Elevator { get; set; }
    }
}
