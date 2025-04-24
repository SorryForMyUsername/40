using System;
using System.Collections.Generic;
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
            MathOps sum = Sum;
            Console.WriteLine($"5 + 6 = {sum.Invoke(5, 6)}");

            MathOps sub = Sub;
            Console.WriteLine($"5 - 6 = {sub.Invoke(5, 6)}");

            MathOps mul = Multiply;
            Console.WriteLine($"5 * 6 = {mul.Invoke(5, 6)}");

            MathOps div = Divide;
            Console.WriteLine($"5 / 6 = {div.Invoke(5, 6)}");

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
