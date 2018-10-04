using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    class JsonDeserializaton
    {
        static void Main(string[] args)
        {

            string json = "{\"Description\":\"Share Knowledge\",\"Name\":\"Surendra\"}";

            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(BlogSite));
                BlogSite bsObj2 = (BlogSite)deserializer.ReadObject(ms);
                Console.Write("Name: " + bsObj2.Name); 
                Console.Write("Description: " + bsObj2.Description);

            }
            Console.ReadLine();
        }
   
    }
}
