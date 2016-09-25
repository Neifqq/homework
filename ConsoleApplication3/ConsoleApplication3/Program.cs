using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            int a = 0, b = 0;
            for (short k = 1; k <= 6; ++k)
            {
                if (k<=3)
                {
                    a += Convert.ToInt32(x % 10 + y % 10);
                    x = Math.Floor(x / 10);
                    y = Math.Floor(y / 10);
                }
                else
                {
                    b += Convert.ToInt32(x % 10 + y % 10);
                    x = Math.Floor(x / 10);
                    y = Math.Floor(y / 10);
                }
            }
            if (a==b)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
