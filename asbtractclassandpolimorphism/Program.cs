namespace asbtractclassandpolimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square Area \n2. Rectangular Area \n0. Quit \nChoose which one are you want to calculate:" );
            int figure = Convert.ToInt32(Console.ReadLine());

            switch (figure)
            {
                case 1:

                    Console.Write("Enter side of square : ");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Square square = new Square(side);
                    Console.Write("Area : ");
                    square.CalcArea();
                    break;
                case 2:
                    Console.Write("Enter width of rectangular : ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter length of rectangular : ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Rectangular rectangular = new Rectangular(width, length);
                    Console.Write("Area : ");
                    rectangular.CalcArea();
                    break;
                case 0:
                    break;
                default:
                    Console.Write("Wrong choice!!");
                    break;
            }
        }
    }
}