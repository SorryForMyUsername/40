using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40
{
    internal class Program
    {
        delegate double MathOps(int m, int n);
        static void Main(string[] args)
        {
            MathOps mathOps = Sum;
            Operation(mathOps);
            Operation(mathOps);
            Operation(mathOps);

            Console.ReadKey(true);
        }

        static void Operation(MathOps func)
        {
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {func.Invoke(m, n)}\n");
        }

        public static double Sum(int m, int n)
        {
            return Enumerable.Range(m, n - m + 1).Sum();
        }
    }
}
