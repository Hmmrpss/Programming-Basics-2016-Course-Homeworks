/* 1. Обръщение според възраст и пол. Първата задача от тази тема е да се напише конзолна програма, която въвежда възраст (десетично число) и пол (“m” или “f”) и отпечатва обръщение измежду следните:
•	“Mr.” – мъж (пол “m”) на 16 или повече години
•	“Master” – момче (пол “m”) под 16 години
•	“Ms.” – жена (пол “f”) на 16 или повече години
•	“Miss” – момиче (пол “f”) под 16 години */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Mr_Ms
    {
        static void Main()
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if (age < 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
            else if (age >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
            /*
             * if (age < 16)
             * {
             * if (gender == "m") Console.WriteLine("Master");}
             * else if (gender == "f") Console.WriteLine("Miss");}
             * else
             * {
             * if (gender == "m") Console.WriteLine("Mr");}
             * ielse f (gender == "f") Console.WriteLine("Ms.");}
        }
    }
}*/
