using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    [Serializable]
    class JsonProgram
    {

        public static void LoadJson()
        {
            using (StreamReader r = new StreamReader("g:\\Surendra2.txt"))
            {
                string json = r.ReadToEnd();
                List<SponsorInfo> items = JsonConvert.DeserializeObject<List<SponsorInfo>>(json);
            }
        }

        public class SponsorInfo
        {
            public decimal SponsorID { get; set; }
            public decimal FirstBAID { get; set; }
            public decimal SecondBAID { get; set; }
            public decimal ThirdBAID { get; set; }

        }

            static void Main(string[] args)
            {
            using (StreamReader r = new StreamReader("g:\\Surendra2.txt"))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                List<SponsorInfo> items = JsonConvert.DeserializeObject<List<SponsorInfo>>(json);
                Console.WriteLine("Serialized Text data Converted into json data");
                foreach (var item in array)
                {
                    Console.Write(item);
                }
            }
            Console.Read();
            
            }
      }
 }

