using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); //считываем набор цифр
            string[] n = s.Split(' '); // берем массив из s(строки разделенные пробелами)


            for (int i = 0; i < n.Length; i++) //пробегаемся по строке
            {
                int test = int.Parse(n[i]); // каждый элемент меняем в int
                bool k = true;
                if (test == 1) // единица не является простым числом
                {
                    continue;
                }
                else
                {
                    for (int j = 2; j <= Math.Sqrt(test); j++)// проверяем вплоть до корня 
                    {
                        if (test % j == 0)
                        {
                            k = false; // делится следовательно оно-составное
                        }
                    }
                    if (k == true)
                    {
                        Console.Write(n[i] + ' '); // в этом же случае оно нам подходит,выводим его
                    }
                }
            }

            Console.ReadKey();
        }
    }
}