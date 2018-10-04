using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization.Serialization
{
    class Addserialization2
    {
            static void Main(string[] args)
            {
            AddSerialization sample = new AddSerialization();  
                sample.Name = "Surendra";
                sample.Age = 24;
                FileStream fileStream = new FileStream(@"g:\\MySoapFile.dat", FileMode.Create);
                SoapFormatter formatter = new SoapFormatter();

                formatter.Serialize(fileStream, sample);
                Console.WriteLine("serialized successfully");
                Console.Read();
            }
        }
    }



