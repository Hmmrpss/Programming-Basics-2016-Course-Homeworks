// Задача 1: Пресмятане на лице на квадрат
//Първата задача от тази тема е следната: да се напише конзолна програма, която въвежда цяло число a и пресмята лицето на квадрат със страна a. Задачата е тривиално лесна: въвеждате число от конзолата, умножавате го само по себе си и печатате получения резултат на конзолата.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main()
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square = ");
            Console.WriteLine(area);
        }
    }
}
