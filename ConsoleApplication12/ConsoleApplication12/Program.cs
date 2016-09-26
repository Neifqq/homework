using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            for (c = 0; c <= 1000; c++)
            {
                for (a = 0; a <= 1000 - c; a++)
                {
                    for (b = 0; b <= 1000 - c - a; b++)
                    {
                        if (a*a + b*b == c*c && a + b + c == 1000)
                        {
                            Console.WriteLine("a={0} b={1} c={2}. a*b*c={3}", a, b, c, a*b*c);
                        }
                    }
                }
            }
            // Пытался через 2 цикла, но не смог сделать нужные условия для них ¯\_(ツ)_/¯
        }
    }
}
