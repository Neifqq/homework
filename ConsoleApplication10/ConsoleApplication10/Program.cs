using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine()), s = 0;
            long p;
            for (p = 3; s <= k; p += 2)
            {
                int j = -1;
                if (p % 3 != 0 && p % 5 != 0)
                {
                    for (int a = 2; (a < p) && (j == -1); a++)
                    {
                        if ((Math.Pow(a, p - 1) - 1) % p == 0)
                        {
                            s++;
                            Console.WriteLine(p);
                            j = -j;
                        }
                    }
                }
            }
        }
    }
}
