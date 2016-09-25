using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine()), x2 = double.Parse(Console.ReadLine()),
                y2 = double.Parse(Console.ReadLine()), x3 = double.Parse(Console.ReadLine()), y3 = double.Parse(Console.ReadLine());
            double r1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2)),
                   r2 = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2)),
                   r3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)),
                   p = (r1 + r2 + r3) / 2;
                   Console.WriteLine(Math.Sqrt(p * (p - r1) * (p - r2) * (p - r3)));
        }
    }
}
