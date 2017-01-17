// Task #5: Изписване на число до 10 с думи. Да се напише програма, която въвежда цяло число в диапазона [0…10] и го изписва с думи на английски език. Ако числото е извън диапазона, изписва “number too big”. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Wrie_a_number
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("number too big");
                        break;
                    default:
                        Console.WriteLine("number too big");
                        break;
                }
            }
        }
    }
}