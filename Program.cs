using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_1
{
    internal class Program
    {
        delegate void Message(); // 1. Объявляется делегат
        static void Main(string[] args)
        {
            Message message; // 2. Создаётся объекта делегата
            if (DateTime.Now.Hour < 12) message = GoodMorning.Output;
            else                        message = GoodDay.Output;
            message();

            Console.ReadKey(true);
        }
    }
}
