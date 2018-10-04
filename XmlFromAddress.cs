using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization.Serialization
{
    class XmlFromAddress
    {
        public static void Main(string[] args)
        {
            AddressDetails details = new AddressDetails();
            details.HouseNo = 4;
            details.StreeName = "Rohini";
            details.City = "Delhi";
            details.Gender = "Male";
            details.Work = "zzzzz";
            //Serialize(details);
            Deserialize(details);
        }
        //static public void Serialize(AddressDetails details)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
        //    using (TextWriter writer = new StreamWriter(@"g:\Xml.xml"))
        //    {
        //        serializer.Serialize(writer, details);
        //    }
        //}
        static public void Deserialize(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (FileStream fileStream = new FileStream(@"g:\Xml.xml", FileMode.Open))
            {
                AddressDetails result = (AddressDetails)serializer.Deserialize(fileStream);
            }
        }
    }
}
