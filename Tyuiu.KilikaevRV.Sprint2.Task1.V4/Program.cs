
using System;
using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;


namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Кочентов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Кочентов Андрей Павлович | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* которая вернет логическую последовательность:                           *");
            Console.WriteLine("* (False, False, False, False, True, False)                               *");
            Console.WriteLine("*                                                                         *");
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
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Логическая последовательность:");
            Console.Write("(");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
                if (i < res.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(")");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПРОВЕРКА:                                                               *");
            Console.WriteLine("***************************************************************************");

            bool[] expected = { false, false, false, false, true, false };
            bool isCorrect = true;

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }

            Console.WriteLine($"Результат корректный: {isCorrect}");
            Console.WriteLine($"Ожидаемый результат:  ({string.Join(", ", expected)})");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Нажмите любую клавишу для выхода...");
        }
    }
}