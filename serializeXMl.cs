using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Serialization.Serialization
{
    public class serializeXMl
    {
        public int Age { get; set; }
        public bool Male { get; set; }
        public string Name { get; set; }
        public void Save ( string fileName)
        {
            using (var stream = new FileStream("G:\\XML.txt", FileMode.OpenOrCreate))
            {
                var XML = new XmlSerializer(typeof(serializeXMl));
                XML.Serialize(stream, this);
            }
        }
        
    }
}
