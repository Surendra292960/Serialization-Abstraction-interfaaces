using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization.Serialization
{
   
    public class AddressDetails
    {
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string StreeName { get;  set; }
        public string Gender { get; set; }
        public string Work { get; set; }
        private string PoAddress { get; set; }
    }
}
