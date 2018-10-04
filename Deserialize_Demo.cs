using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    [Serializable]
    class Deserialze_Demo
    {
        public static void Main()
        {
            FileStream fs = new FileStream("g:\\serial_demo.txt", FileMode.Open);
            BinaryFormatter bfm = new BinaryFormatter();
            Serialize1 sr = (Serialize1)bfm.Deserialize(fs);
            Console.WriteLine("std_id = " + sr.std_id);
            Console.WriteLine("std_name= " + sr.std_name);
            Console.ReadLine();


        }
    }
}
