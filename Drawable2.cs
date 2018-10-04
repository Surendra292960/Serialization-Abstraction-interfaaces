using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    interface Drawable2
    {
       void draw();
    }

    public class A : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Hello from A");
        }
    }
    public class B : Drawable
    {
        public void draw()
        {
            Console.WriteLine("Hello from B");
        }
    }
    public class TestDraw
    {
        static void Main(string[] args)
        {
            Drawable d;
            d = new A();
            d.draw();
            d = new B();
            d.draw();
            Console.ReadLine();
        }
    }
}
