using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            int p = 1;

            for (int i = a; i <= b; i++)
            {
                p *= i;
            }

            Console.WriteLine("Ну что то получается: " + p);
            Console.ReadKey();
        }
    }
}
