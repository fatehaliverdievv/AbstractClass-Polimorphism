using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asbtractclassandpolimorphism
{
    internal class Rectangular:Figure
    {
        int _width;
        int _length;
        public int Width { get { return _width; } set { if (value > 0) { _width = value; } else { Console.WriteLine("Wrong input"); } } }
        public int Length { get { return _length; } set { if (value > 0) { _length = value; } else { Console.WriteLine("Wrong input"); } } }

        public override void CalcArea()
        {
            Console.WriteLine(Width*Length);
        }
        public Rectangular(int width, int length)
        {
            Width = width;
            Length = length;
        }
    }
}
