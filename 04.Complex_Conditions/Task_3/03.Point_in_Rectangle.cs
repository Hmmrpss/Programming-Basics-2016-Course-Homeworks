/* 3. Точка в правоъгълник
Напишете програма, която проверява дали точка {x, y} се намира вътре в правоъгълник {x1, y1} – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда: десетичните числа x1, y1, x2, y2, x и y (като се гарантира, че x1 < x2 и y1 < y2). Една точка е вътрешна за даден правоъгълник, ако се намира някъде във вътрешността му или върху някоя от страните му. Отпечатайте “Inside” или “Outside”. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            bool pointisontheline = ((x==x1 || x==x2) && (y==y1 || y==y2));
            bool pointisintherectangle = x >= x1 && x <= x2 && y >= y1 && y <= y2;
            if (pointisintherectangle || pointisontheline)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
