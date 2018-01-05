using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.LocationModel
{
    public class Rootobject
    {
 
        public int region { get; set; }
        public string valid { get; set; }
        public string hostname { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public string countryCode { get; set; }
        public string city { get; set; }
        public string country { get; set; }
    }

}