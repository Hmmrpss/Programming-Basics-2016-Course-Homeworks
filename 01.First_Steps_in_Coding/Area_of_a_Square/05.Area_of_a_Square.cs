using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Square
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a =");
            var side = double.Parse(Console.ReadLine());
            var square = side * side;
            Console.WriteLine("Area = {0}", square);
        }
    }
}
