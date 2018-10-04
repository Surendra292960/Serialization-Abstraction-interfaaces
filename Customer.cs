using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections;

namespace Serialization.Serialization
{
    [Serializable]
    class Customer
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Surendra",
                Address = "BTM",
                Hobbies = new List<string>()
                {
                    "Reading",
                    "Playing Games"
                }
            };

            string strResultJson = JsonConvert.SerializeObject(emp);
            Console.WriteLine(strResultJson);
            File.WriteAllText(@"Customers.json", strResultJson);
            Console.WriteLine("stored");


            strResultJson = String.Empty;
            StreamWriter obj = new StreamWriter("g:\\CustomerClass");
            
            strResultJson = File.ReadAllText(@"Customers.json");
            //Employee resultEmployee = JsonConvert.DeserializeObject<Employee>(strResultJson);
            //Console.WriteLine(resultEmployee.ToString());

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach(DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + "," + entry.Value);
            }
            Console.Read();
        }
      }
  }

    

