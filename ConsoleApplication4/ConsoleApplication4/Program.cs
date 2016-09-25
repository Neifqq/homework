using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            long n10 = long.Parse(Console.ReadLine());
            string n16 = "";
            string[] ch = { "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"}; 
            // Вспомогательные массивы же разрешены?
            do
            {
                long k = n10 % 16;      // Считаем остаток
                n16 = ch[k] + n16;      // и берем его в 16-тиричной системе счисления.
                n10 = (long)(n10 / 16);
            }
            while (n10 > 0);
            Console.WriteLine(n16);
        }
    }
}
