using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization.Serialization
{
    class XmlSerializationDeserialiZation
    {
        static void Main(string[] args)
        {


            string testData = @"<StepList>
                        <Step>
                            <Name>Name1</Name>
                            <Desc>Desc1</Desc>
                        </Step>
                        <Step>
                            <Name>Name2</Name>
                            <Desc>Desc2</Desc>
                        </Step>
                    </StepList>";

            XmlSerializer serializer = new XmlSerializer(typeof(StepList));
            using (TextReader reader = new StringReader(testData))
            {
                StepList result = (StepList)serializer.Deserialize(reader);
            }
            Console.ReadLine();
        }
    }
}
