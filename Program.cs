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
        delegate int MathOps(int a, int b);
        static void Main(string[] args)
        {
            Console.Write("M = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int b = int.Parse(Console.ReadLine());

            MathOps sum = Sum;
            Console.WriteLine($"{a} + {b} = {sum.Invoke(a, b)}");

            MathOps sub = Sub;
            Console.WriteLine($"{a} - {b} = {sub.Invoke(a, b)}");

            MathOps mul = Multiply;
            Console.WriteLine($"{a} * {b} = {mul.Invoke(a, b)}");

            MathOps div = Divide;
            Console.WriteLine($"{a} / {b} = {div.Invoke(a, b)}");

            Console.ReadKey();
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
