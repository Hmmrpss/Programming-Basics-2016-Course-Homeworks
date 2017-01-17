/* Task #9:  Познай паролата
Да се напише програма, която въвежда парола (един ред с произволен текст) и проверява дали въведеното съвпада с фразата “s3cr3t!P@ssw0rd”. При съвпадение да се изведе “Welcome”. При несъвпадение да се изведе “Wrong password!”.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Guess_the_password
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("WRong password !");
            }
        }
    }
}
