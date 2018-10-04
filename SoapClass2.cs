using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization.Serialization
{
    class SoapClass2
    {
            static void Main()
            {
                try

                {
                    SoapCLass objSecrete = new SoapCLass();

                    objSecrete.MyAccNum = 18225665;



                    //Soap serialization technique

                    SoapFormatter formatter = new SoapFormatter();

                    Stream objfilestream = new FileStream("g:\\Myserialzed.xml", FileMode.Create, FileAccess.Write, FileShare.None);



                    formatter.Serialize(objfilestream, objSecrete);

                    objfilestream.Close();

                    //deserialization

                    Stream objreadstream = new FileStream("F:\\Myserialzed.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

                    SoapCLass objSecrete2 = (SoapCLass)formatter.Deserialize(objreadstream);



                    int Myaccno = objSecrete2.MyAccNum;

                    Console.WriteLine("AccNo:{0} " + Myaccno.ToString());

                }

                catch (Exception ex)

                {

                }

            }
        }
    }


