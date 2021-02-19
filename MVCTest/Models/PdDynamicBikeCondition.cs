using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest
{
    public partial class PdDynamicBikeCondition
    {
        public long Ids { get; set; }
        public string Stationuid { get; set; }
        public string County { get; set; }
        public int? Available { get; set; }
        public int? Rents { get; set; }
        public int? Returns { get; set; }
        public string Updatetime { get; set; }
    }
}
