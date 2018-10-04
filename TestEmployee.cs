using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class TestEmployee
    {
        static void Main(string[] args)
        {
            EmployeeIndexer Emp = new EmployeeIndexer(1001,"scott","Manager",20000.00,"Sales","Mumbai");
            Console.WriteLine("\n1st iteration using by object reference & index.........");
            Console.WriteLine("Eno:" + Emp[0]);
            Console.WriteLine("Ename:" + Emp[1]);
            Console.WriteLine("Job:" + Emp[2]);
            Console.WriteLine("Esal:" + Emp[3]);
            Console.WriteLine("Dname:" + Emp[4]);
            Console.WriteLine("Location:" + Emp[5]);
            Console.WriteLine("\n2rd iteration using by forloop.........");
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine(Emp[i]+",");
            }

           
            Emp[2] = "Sr.Manager";
            Emp[3] = 25000.00;
            Console.WriteLine("\n3rd iteration using by object reference & String as an index.........");
            Console.WriteLine("Eno:" + Emp["Eno"]);
            Console.WriteLine("Ename:" + Emp["Ename"]);
            Console.WriteLine("Job:" + Emp["Job"]);
            Console.WriteLine("Esal:" + Emp["Salary"]);
            Console.WriteLine("Dname:" + Emp["dname"]);
            Console.WriteLine("Location:" + Emp["Location"]);

            Console.ReadLine();
        }
    }
}
