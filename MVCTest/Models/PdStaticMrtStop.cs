using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
#nullable disable

namespace MVCTest.Models
{
    public class PdStaticMrtStop
    {
        public long Ids { get; set; }
        public string County { get; set; }
        public string Lineid { get; set; }
        public string Routeid { get; set; }
        public string Stationid { get; set; }
        public string Stationname { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Updatedate { get; set; }
        public string Checkdate { get; set; }
    }
}
