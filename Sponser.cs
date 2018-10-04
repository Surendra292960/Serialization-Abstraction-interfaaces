using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Serialization.Serialization
{
    [Serializable]
    class Sponser
    {
        static void Main(string[] args)
        {
            var jsonText = File.ReadAllText("g:\\Surendra2.txt");
            var sponsors = JsonConvert.DeserializeObject<IList<SponserInfo>>(jsonText);
            var sponsor5 = sponsors.FirstOrDefault(x => x.SponsorID == 5);
            var sponsorsById = sponsors.ToDictionary(x => x.SponsorID);
          
            Console.WriteLine(sponsors);
            Console.ReadLine();


        }
    }
}

