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
            IOAverage();
            IOAverage();
            IOAverage();

            Console.ReadKey();
        }

        static void IOAverage()
        {
            MathOps mathOps = Average;
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое чисел от {m} до {n}: {mathOps.Invoke(m, n)}\n");
        }

        public static double Average(int m, int n)
        {
            return Enumerable.Range(m, n - m + 1).Average();
        }
    }
}
