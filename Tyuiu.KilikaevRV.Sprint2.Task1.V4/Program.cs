using System;
using Tyuiu.KilkaevRV.Sprint2.Task1.V4.Lib;

namespace Tyuiu.KilkaevRV.Sprint2.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Логические операции для получения последовательности:");
            Console.WriteLine("[false, false, false, false, true, false]");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.Calculate();

            if (result == null || result.Length == 0)
            {
                Console.WriteLine("Ошибка: массив пустой!");
            }
            else
            {
                Console.WriteLine("Логическая последовательность:");
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine($"[{i}] = {result[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}