using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    class JsonSerialization
    {
        static void Main(string[] args)
        {

            BlogSite bsObj = new BlogSite()
            {
                Name = "Surendra",
                Description = "Share Knowledge"
            };

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(BlogSite));
            MemoryStream msObj = new MemoryStream();
            js.WriteObject(msObj, bsObj);
            msObj.Position = 0;
            StreamReader sr = new StreamReader(msObj); 
            string json = sr.ReadToEnd();

            sr.Close();
            msObj.Close();
            Console.ReadLine();
        }
    }
}
