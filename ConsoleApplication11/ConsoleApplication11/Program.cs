using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine()), a = 2;
            while (n > 1)
            {
                if (n % a == 0)
                {
                    n /= a;
                }
                else
                {
                    a++;
                }
            }
            Console.WriteLine(a);
        }
    }
}
