using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
   public class Program2
    {
        static void Main(string[] args)
        {
            serializeXMl class1 = new serializeXMl();

            class1.Age = 10;
            class1.Male = true;
            class1.Name = "Surendra";
            //class1.Save = ("g:\\hey.xml");
        }
    }
}
