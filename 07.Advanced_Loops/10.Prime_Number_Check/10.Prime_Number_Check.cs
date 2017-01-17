/* Задача 10: Проверка за просто число
Напишете програма, която въвежда цяло число n и проверява дали е просто число (дали се дели само на себе си и на единица). Да се отпечата “Prime” или “Not prime”. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Prime_Number_Check
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool primeNumber = true;
            for (int i = 2; i <= Math.Sqrt(input); i++) // proverka za delene na input na 2 i vsichki chisla do korena mu
            {
                if (input % i == 0) //proverka za chetno chislo =>  not prime
                {
                    primeNumber = false;
                    break;
                }
            }
            if (primeNumber)
            {
                Console.WriteLine("Prime"); 
            }
            else
            {
                Console.WriteLine("Not Prime"); 
            }
        }
    }
}
