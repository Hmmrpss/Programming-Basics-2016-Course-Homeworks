/* Задача 6: Число в диапазона [1…100]
Напишете програма, която въвежда цяло положително число n в диапазона [1…100]. При въвеждане на число извън посочения диапазон, да се отпечата съобщение за грешка и потребителят да се подкани да въведе ново число. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1_to_100_
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number in the range [1...100]:");
            int givenNumber = int.Parse(Console.ReadLine());
            while (givenNumber <= 0 || givenNumber >= 101)
            {
                Console.WriteLine("Invalid number!");
            }
            Console.WriteLine("The number is: {0}", givenNumber);
        }
    }
}
