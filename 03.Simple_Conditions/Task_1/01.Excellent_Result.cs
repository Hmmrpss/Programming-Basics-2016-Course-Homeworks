// Task #1: Първата задача от тази тема е да се напише конзолна програма, която въвежда оценка (десетично число) и отпечатва “Excellent!”, ако оценката е 5.50 или по-висока. //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Proverka_na_ocenka
    {
        static void Main()
        {
            var ocenka = double.Parse(Console.ReadLine());
            if (ocenka >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
