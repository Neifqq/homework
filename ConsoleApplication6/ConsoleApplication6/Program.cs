using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // string s = Console.ReadLine();
            // int k = int.Parse(Console.ReadLine());
            // int S = Convert.ToInt32(s, k);
            // double r = S;
            // Если задаётся основание.
            double r = double.Parse(Console.ReadLine());
            do
            {
                if (r % 2 == 0)
                {
                    Console.Write("0");
                }
                r = Math.Floor(r / 2);
            }
            while (r > 0);
            Console.WriteLine("");
        }
    }
}
