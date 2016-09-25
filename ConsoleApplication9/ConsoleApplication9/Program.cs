using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, plus = 0, minus = 0, p = 0; // p - разница между количеством положительных и отрицательных чисел.
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    p--;
                    minus += x;
                }
                if (x > 0)
                {
                    p++;
                    plus += x;
                }
            }
            while (x != 0);
            if (p == 0)
            {
                Console.WriteLine("Условиями задачи такой результат не предусмотрен :(");
            }
            else
            {
                if (p < 0)
                {
                    Console.WriteLine(minus);
                }
                else
                {
                    Console.WriteLine(plus);
                }
            }
        }
    }
}
