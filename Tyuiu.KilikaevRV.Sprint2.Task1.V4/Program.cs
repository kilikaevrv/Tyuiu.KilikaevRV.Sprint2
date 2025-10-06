using System;
using Tyuiu.KilkaevRV.Sprint2.Task4.V4.Lib;

namespace Tyuiu.KilkaevRV.Sprint2.Task4.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.Calculate();

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Подробная расшифровка операций:");
            Console.WriteLine($"(175 + b) < (a + 176)    -> (175 + {b}) < ({a} + 176)    -> {result[0]}");
            Console.WriteLine($"(b - 175) > (176 - a)    -> ({b} - 175) > (176 - {a})    -> {result[1]}");
            Console.WriteLine($"(175 * b) < (a * 176)    -> (175 * {b}) < ({a} * 176)    -> {result[2]}");
            Console.WriteLine($"(b / 175) > (176 / a)    -> ({b} / 175) > (176 / {a})    -> {result[3]}");
            Console.WriteLine($"(175 % b) == (a % 176)   -> (175 % {b}) == ({a} % 176)   -> {result[4]}");
            Console.WriteLine($"(b + 175) != (176 + a)   -> ({b} + 175) != (176 + {a})   -> {result[5]}");

            Console.ReadKey();
        }
    }
}