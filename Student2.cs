using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Serialization
{
    [Serializable]
    class Student2
    {
        public int rollno;
        public string name;
        public Student2(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("g:\\Surendra.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
         
                Student s = (Student)formatter.Deserialize(stream);
                Console.WriteLine("Conversion succeeded.");
                Console.WriteLine("Rollno: " + s.rollno);
                Console.WriteLine("Name: " + s.name);
                stream.Close();
                Console.Read();
        }
    }
}
