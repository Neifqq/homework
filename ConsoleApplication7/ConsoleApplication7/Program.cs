using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0, x;
            do
            {
                x = int.Parse(Console.ReadLine());
                while (x % 2 == 0 && x > 1)
                {
                    s++;
                    x = x / 2;
                }
            }
            while (x != 0);
            Console.WriteLine("Степеней двойки: {0}",s);
        }
    }
}
