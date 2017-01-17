using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_3_Numbers
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            bool checker = (a + b == c);
            if (checker)
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
