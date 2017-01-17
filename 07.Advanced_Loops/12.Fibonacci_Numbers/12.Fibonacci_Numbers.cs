/*Задача 12: Числа на Фибоначи
Напишете програма, която въвежда цяло число n и пресмята n-тото число на Фибоначи. Нулевото число на Фибоначи е 1, първото е също 1, а всяко следващо е сумата от предходните две. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Fibonacci_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 1;
            int secondNumber = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
            }
            Console.WriteLine(firstNumber);
        }
    }
}
