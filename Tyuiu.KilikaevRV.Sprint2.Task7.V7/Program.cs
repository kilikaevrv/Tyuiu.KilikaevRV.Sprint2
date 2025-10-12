using System;
using Tyuiu.KilikaevRV.Sprint2.Task7.V7.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Килияев Р. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Проверка попадания точки в заштрихованную область                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Килияев Роман Валерьевич | ИИПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами  *");
            Console.WriteLine("* X,Y в заштрихованной области, ограниченной параболой y = 2 - x².       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            // Вычисляем значение параболы в точке x для информативности
            double parabolaY = 2 - Math.Pow(x, 2);

            Console.WriteLine($"Координаты точки: X = {x}, Y = {y}");
            Console.WriteLine($"Значение параболы y = 2 - x² в точке X = {x}: {parabolaY:F3}");

            if (result)
            {
                Console.WriteLine($"Точка находится ВНУТРИ заштрихованной области");
                Console.WriteLine($"Условие: Y <= {parabolaY:F3} выполняется");
            }
            else
            {
                Console.WriteLine($"Точка находится ВНЕ заштрихованной области");
                Console.WriteLine($"Условие: Y <= {parabolaY:F3} не выполняется");
            }

            Console.WriteLine();
            Console.WriteLine("Область ограничена:");
            Console.WriteLine("- Параболой: y = 2 - x²");
            Console.WriteLine("- По X: от -2 до 2");
            Console.WriteLine("- По Y: от -2 до 2");

            Console.ReadKey();
        }
    }
}