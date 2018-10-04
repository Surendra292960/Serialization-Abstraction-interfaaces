using System;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Serialization.Serialization
{
    class JSONToString
    {
        static void Main(string[] args)
        {
  string json = @"{
  ""Name"": ""Apple"",
  ""Expiry"": new Date(1230422400000),
  ""Price"": 3.99,
  ""Sizes"": [
    ""Small"",
    ""Medium"",
""Large""]
}";

            //Object resultEmployee = JsonConvert.DeserializeObject<Object>(json);
            //Console.WriteLine(resultEmployee);

            string strResultJson = JsonConvert.SerializeObject(json);
            Console.WriteLine(strResultJson);

            Console.ReadLine();
        }

    }
}
