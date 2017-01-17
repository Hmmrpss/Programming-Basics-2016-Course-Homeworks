// Задача 7: Лице на правоъгълник в равнината
//Правоъгълник е зададен с координатите на два от своите срещуположни ъгъла (x1, y1) – (x2, y2). Да се пресметнат площта и периметъра му. Входът се чете от конзолата. Числата x1, y1, x2 и y2 са дадени по едно наред. Изходът се извежда на конзолата и трябва да съдържа два реда с по една число на всеки от тях – лицето и периметъра.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Abs(x1 - x2);
            var height = Math.Abs(y1 - y2);
            var area = width * height;
            var perimeter = 2 * (width + height);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
