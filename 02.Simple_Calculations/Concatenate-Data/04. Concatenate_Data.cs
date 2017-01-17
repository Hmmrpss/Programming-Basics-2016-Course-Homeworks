// Задача 4: Съединяване на текст и числа
//Напишете C# програма, която прочита от конзолата име, фамилия, възраст и град и печата съобщение от следния вид: “You are <firstName> <lastName>, a <age>-years old person from <town>”.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Please, write your first name, last name, age and the city you are from: ");
            var firstname = Console.ReadLine();
            var lastname = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}", firstname, lastname, age, town);
        }
    }
}
