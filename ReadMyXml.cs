using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace ConsoleApp1.Exception_and_Indexers
{
    class ReadMyXml
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create(@"g:\\myXmFile.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "Name":
                                Console.WriteLine("Name of the Element is : " + reader.ReadString());
                                break;
                            case "Address":

                                Console.WriteLine("Your Address is : " + reader.ReadString());
                                break;
                        }

                    }

                    Console.WriteLine("");
                }

            }

            Console.ReadKey();

        }

    }
}
