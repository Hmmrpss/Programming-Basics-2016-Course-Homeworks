/* Task #12: Информация за скоростта
Да се напише програма, която въвежда скорост (десетично число) и отпечатва информация за скоростта. При скорост до 10 (включително) отпечатайте “slow”. При скорост над 10 и до 50 отпечатайте “average”. При скорост над 50 и до 150 отпечатайте “fast”. При скорост над 150 и до 1000 отпечатайте “ultra fast”. При по-висока скорост отпечатайте “extremely fast”. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Speed_check
    {
        static void Main()
        {
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 10.0)
            {
                Console.WriteLine("slow");
            }
            else if (speed >=10 && speed <= 50) //ll//
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150) //ll//
            {
                 Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1000) //ll//
            {
                 Console.WriteLine("ultra fast");
            }
            else 
            {
                 Console.WriteLine("extremely fast");
            }
        }

    }
}
