using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ConsoleApp1.Exception_and_Indexers
{
    class Json2
    {
        public string email_address { get; set; }
        public string status { get; set; }

        static void Main(string[] args)
        {
            List<Json2> data = new List<Json2>() { new Json2() { email_address = "email1@email.com", status = "good2go" }, new Json2() { email_address = "email2@email.com", status = "good2go" } };

            //Serialize
            var json = JsonConvert.SerializeObject(data);

            //Deserialize
            var jsonToList = JsonConvert.DeserializeObject<List<MyClass>>(json);

            Console.ReadLine();
        }
    }
}
