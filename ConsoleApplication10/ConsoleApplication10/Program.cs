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
            int n = int.Parse(Console.ReadLine());
            long s = 0;
            for (long i = (long)Math.Pow(10,n-1); i < (long)Math.Pow(10,n); i++)
            {
                s += i;
            }
            Console.WriteLine(s);
        }    
    }
}
