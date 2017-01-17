/* 4. Плод или зеленчук?
Да се напише програма, която въвежда име на продукт и проверява дали е плод или зеленчук.
•	Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
•	Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
•	Всички останали са "unknown"
Да се изведе “fruit”, “vegetable” или “unknown” според въведения продукт.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class fruit_or_vegetable
    {
        static void Main()
        {
            var productname = Console.ReadLine().ToLower();
            if (productname == "banana" 
                || productname == "apple"
                || productname == "kiwi" 
                || productname == "cherry" 
                || productname == "lemon" 
                || productname == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (productname == "tomato"
                || productname == "cucumber"
                || productname == "pepper"
                || productname == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
