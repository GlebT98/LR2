using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LR2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(4, 7);
            var square = new Square(8);
            var circle = new Circle(10);

            var figures = new Figure[] { rect, square, circle };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.area());
            }

            var prints = new IPrint[] { rect, square, circle };

            foreach (var print in prints)
            {
                print.Print();
            }
        }
    }
}
