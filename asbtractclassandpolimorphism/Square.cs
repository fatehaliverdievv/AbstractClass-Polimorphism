using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asbtractclassandpolimorphism
{
    internal class Square : Figure
    {
        int _side;
        public int Side
        {
            get { return _side; }
            set { if (value > 0) { _side = value; } else { Console.WriteLine("Wrong input"); } }
        }
        public override void CalcArea()
        {
            Console.WriteLine(Side*Side);
        }
        public Square(int side)
        {
            Side = side;
        }
    }
}
