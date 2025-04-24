using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_1
{
    internal class Program
    {
        delegate double MathOps(int m, int n);
        static void Main(string[] args)
        {
            MathOps mathOps = Average;
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(mathOps.Invoke(m, n));

            Console.ReadKey();
        }

        static double Average(int m, int n)
        {
            return Enumerable.Range(m, n - m + 1).Average();
        }
    }
}
