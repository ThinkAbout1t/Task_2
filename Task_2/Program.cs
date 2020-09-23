using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("введіть змінну типу int: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введіть змінну типу double: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("введіть змінну типу long: ");
            long c = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine($"a = {a}; b = {b}; с = {c}");
        }
    }
}
