using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticModifier
{
    internal class Car
    {
        public static int numberofcars;

        public Car()
        {
            numberofcars++;
        }

        public static void addcars()
        {
            Console.WriteLine("The race has started");
        }
    }
}
