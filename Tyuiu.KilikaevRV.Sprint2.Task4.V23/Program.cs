using System;
using Tyuiu.KilikaevRV.Sprint2.Task4.V23.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Килияев Р. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Килияев Роман Валерьевич | ИИПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тернарного оператора.                                    *");
            Console.WriteLine("* Если x + 2 < sqrt(y) + 3, то z = (1 + 1/y²)^x                          *");
            Console.WriteLine("* иначе y + 12x - (1/x)                                                   *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);

            // Проверяем какое условие выполнилось для информативности
            bool condition = (x + 2 < Math.Sqrt(y) + 3);
            string formulaUsed = condition
                ? $"z = (1 + 1/{y}²)^{x}"
                : $"y + 12x - (1/x) = {y} + 12*{x} - (1/{x})";

            Console.WriteLine($"Условие (x + 2 < sqrt(y) + 3): {condition}");
            Console.WriteLine($"Использованная формула: {formulaUsed}");
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}