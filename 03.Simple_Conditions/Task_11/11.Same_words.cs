/* Task #11:  Еднакви думи
Да се напише програма, която въвежда две думи и проверява дали са еднакви. Да не се прави разлика между главни и малки думи. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Same_words
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            string first = input1.ToLower();
            string input2 = Console.ReadLine();
            string second = input2.ToLower();
            if (first == second)
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
