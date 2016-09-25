using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), c = int.Parse(Console.ReadLine());
            if (a==0 & b==0 & c==0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                double D = (b * b - 4 * a * c);
                if (D >= 0)
                {
                    if (D == 0)
                    {
                        Console.WriteLine(-b / (2 * a));
                    }
                    else
                    {
                        Console.WriteLine((-b - Math.Sqrt(D)) / (2 * a));
                        Console.WriteLine((-b + Math.Sqrt(D)) / (2 * a));
                    }
                }
            }
        }
    }
}
