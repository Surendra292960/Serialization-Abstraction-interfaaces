using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exception_and_Indexers
{
    class SystemExceptionClass1
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 25;
            }
            catch(SystemException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
