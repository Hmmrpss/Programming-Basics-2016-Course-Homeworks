/* Задача 11: Въвеждане на четно число (с обработка на грешен вход)
Напишете програма, която въвежда четно число. Ако потребителят въведе грешно число (нечетно число или стринг, който не е цяло число), трябва да му излиза съобщение за грешка и да въвежда отново. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_an_Even_Number
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter even number: ");
                int givenNumber = int.Parse(Console.ReadLine());
                bool evenNumber = (givenNumber % 2 == 0);
                if (!evenNumber)
                {
                    Console.WriteLine("Even number entered: {0}", givenNumber);
                }
                else
                {
                    Console.WriteLine("The number is not even!");
                }
            }
            catch () // lookup
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
string text = Console.ReadLine();
while()
{
try{int num = int.TryParse(text);
if (num % 2 == 0){Console.WriteLine("Even number enterred: {0}" num); break;
}
else {
text = Console.ReadLine();}
catch (Exeption) {Console.WriteLine("Invalid Number!");}
}