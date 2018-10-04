using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Hello from rectangle");
        }
        public class Circle : Shape
        {
            public override void draw()
            {
                Console.WriteLine("Hello from Circle");
            }
        }
        public class TestAbstract
        {
            static void Main(string[] args)
            {
                Shape a;
                a = new Rectangle();
                a.draw();
                a = new Circle();
                a.draw();
                Console.Read();
            }
        }
    }
}
