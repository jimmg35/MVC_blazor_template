using System;
using System.Collections.Generic;

#nullable disable

namespace MVCTest
{
    public partial class UdUserInfo
    {
        public long Ids { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? Subs { get; set; }
        public string County { get; set; }
        public string Lineid { get; set; }
        public string Linename { get; set; }
        public string Geometry { get; set; }
        public string Updatedate { get; set; }
        public string Checkdate { get; set; }
    }
}
