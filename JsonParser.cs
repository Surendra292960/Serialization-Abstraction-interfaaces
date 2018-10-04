using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1.Exception_and_Indexers
{
    class JsonParser
    {
        [Serializable] 
        public class items2
        {
            [XmlElement]
            public List<item2> item2 { get; set; }
        }

        [Serializable]
        public class item2
        {
            public int id { get; set; }
            public string name { get; set; }
        }
    }
}
