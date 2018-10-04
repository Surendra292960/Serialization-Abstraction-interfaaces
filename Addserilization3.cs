using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
namespace Serialization.Serialization
{
    class Addserilization3
    {
       static void Main(string[] args)
            {
                FileStream fileStream = new FileStream(@"g:\\MySoapFile.dat", FileMode.Open);
                SoapFormatter formatter = new SoapFormatter();
                AddSerialization deserializedSample = (AddSerialization)formatter.Deserialize(fileStream);
                Console.WriteLine("The deserialized object:");
                Console.WriteLine(String.Format("Name: {0}", deserializedSample.Name));
                Console.WriteLine(String.Format("Value: {0}", deserializedSample.Age.ToString()));

                Console.Read();
            }
        }
    }

