using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                x = int.Parse(Console.ReadLine());
                if (x > 0)
                {
                    int s = 0, k = 1;
                    while (k < x)
                    {
                        k *= 2;
                        s++;
                        
                    }
                    Console.WriteLine("Ответ: {0}",Math.Pow(2, s));
                }
                else
                {
                    Console.WriteLine("Ответ: {0}",Math.Abs(x));
                }
            }
            while (x != 0);
        }
    }
}
