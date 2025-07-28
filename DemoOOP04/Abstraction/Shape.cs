using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Abstraction
{
    internal abstract class Shape
    {
        public int Dim01 { get; set; }
        public int Dim02 { get; set; }

        public abstract double GetArea();

        public abstract double perimeter { get; }

        public void print()
        {
            Console.WriteLine("I'm shape");
        }

    }
}
