using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string n16 = Console.ReadLine(), nk;
            long k = long.Parse(Console.ReadLine());
            int[] ch = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            long n10 = Convert.ToInt64(n16, 16);
            do
            {
                long l = n10 % k;
                nk = ch[l] + n16;
                n10 = (long)(n10 / k);
            }
            while (n10 > 0);
            Console.WriteLine(nk);
        }
    }
}
