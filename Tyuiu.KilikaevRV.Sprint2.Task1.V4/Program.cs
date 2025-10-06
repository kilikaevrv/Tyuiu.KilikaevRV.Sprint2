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

            bool[] result = new bool[5];
            result = ds.Calculate(result);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Подробная расшифровка операций:");
            Console.WriteLine($"(a == b) | (c != d)     -> ({a} == {b}) | ({c} != {d})     -> {result[0]}");
            Console.WriteLine($"(a < b) & (c > d)       -> ({a} < {b}) & ({c} > {d})       -> {result[1]}");
            Console.WriteLine($"(b <= a) || (c < d)     -> ({b} <= {a}) || ({c} < {d})     -> {result[2]}");
            Console.WriteLine($"(a != b) && (c == d)    -> ({a} != {b}) && ({c} == {d})    -> {result[3]}");
            Console.WriteLine($"!(a > b) ^ (c <= d)     -> !({a} > {b}) ^ ({c} <= {d})     -> {result[4]}");

            Console.ReadKey();
        }
    }
}