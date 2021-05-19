using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число с 1 до 15 перевду в двоичную систему");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
                    {
                case  1:
                    {
                        Console.WriteLine("1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("10");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("11");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("100");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("101");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("110");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("111");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("1000");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("1001");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("1010");
                        break;
                    }
                case 11:
                    {
                        Console.WriteLine("1011");
                        break;
                    }
                case 12:
                    {
                        Console.WriteLine("1100");
                        break;
                    }
                case 13:
                    {
                        Console.WriteLine("1101");
                        break;
                    }
                case 14:
                    {
                        Console.WriteLine("1110");
                        break;
                    }
                case 15:
                    {
                        Console.WriteLine("1111");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ну короче ты что то не то ввел и получил шлак");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
