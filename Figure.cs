using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    abstract class Figure: IPrint
    {
        public abstract double area();

        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
