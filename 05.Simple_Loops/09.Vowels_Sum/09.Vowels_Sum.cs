/* 9.	Сумиране на гласните букви
Да се напише програма, която въвежда текст (стринг) и изчислява и отпечатва сумата от стойностите на гласните букви според таблицата по-долу:
буква	a	e	i	o	u
стойност	1	2	3	4	5
Примери: 
вход	изход	коментар
hello	6	e + o = 2 + 4 = 6
hi	3	i = 3
bamboo	9	a + o + o = 1 + 4 + 4 = 9
beer	4	e + e = 2 + 2 = 4*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main()
        {
            string text_input = Console.ReadLine();
            int letter_value = 0;
            int sum = 0;
            for (int i = 0; i < text_input.Length; i++)
            {
                switch (text_input[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                }
                sum += letter_value;
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
