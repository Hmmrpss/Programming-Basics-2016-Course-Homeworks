/* 6. Точка върху страната на правоъгълник
Напишете програма, която проверява дали точка {x, y} се намира върху някоя от страните на правоъгълник {x1, y1} – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда: десетичните числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2). Да се отпечата “Border” (точката лежи на някоя от страните) или “Inside / Outside” (в противен случай). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class point_on_border
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());             //A=x1x2 B=x1y1 C=x2y2 D=y1y2
            var y1 = double.Parse(Console.ReadLine());             // x==x1 && x<=x2
            var x2 = double.Parse(Console.ReadLine());             // y==y2 && ()
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            bool A = ((x == x1) && ((y1 <= y) || (y <= y2)));
            bool B = ((x == x2) && ((y1 <= y) || (y <= y2)));
            bool C = ((y == y1) && ((x1 <= x) || (x <= x2)));
            bool D = ((y == y2) && ((x1 <= x) || (x <= x2)));
            if (A || B || C || D)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}