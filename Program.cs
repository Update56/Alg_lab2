using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;

namespace Alg_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long x = 1;
            while (x != 0) {
                Console.Write("x = ");
                x = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"Ответ: f = {f(x)}");
            }
        }
        static long f(long x)
        {
            int z = 0;
            while (!(x + 10 < Math.Pow(2,z+1)) && z <= x + 10) 
                z++;
            return z;
        }
    }
}
