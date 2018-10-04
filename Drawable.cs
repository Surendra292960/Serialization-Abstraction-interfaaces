using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    interface Drawable
    {
        void draw();
    }

    public class rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectagle");
        }
    }
    public class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle");
        }
    }
    public class TestInterface
        {
        static void Main(string[] args)
        {
            Drawable d;
            d = new rectangle();
            d.draw();
            d = new Circle();
            d.draw();
            Console.ReadLine();
        }
     }
}
