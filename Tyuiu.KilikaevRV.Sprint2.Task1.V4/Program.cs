
using System;
using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Килияев Р. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Килияев Роман Валерьевич | ИИПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* которая вернет логическую последовательность:                           *");
            Console.WriteLine("* (False, False, False, False, True, False)                               *");
            Console.WriteLine("* при a = 175, b = 176, c = 414, d = 414                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

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
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetLogicOperation(a, b, c, d);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Ожидаемая последовательность:");
            Console.WriteLine("[0] = False");
            Console.WriteLine("[1] = False");
            Console.WriteLine("[2] = False");
            Console.WriteLine("[3] = False");
            Console.WriteLine("[4] = True");
            Console.WriteLine("[5] = False");

            Console.ReadKey();
        }
    }
}