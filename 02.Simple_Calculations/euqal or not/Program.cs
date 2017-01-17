using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euqal_or_not
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            bool aequalb = Math.Equals(a, b);
            bool aequalc = Math.Equals(a, c);
            if (aequalb && aequalc)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
