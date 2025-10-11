using System;

namespace Tyuiu.KilikaevRV.Sprint2.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tyulu.KilikaevRV.Sprint3.Task1.V8");
            Console.WriteLine("Вариант 8");
            Console.WriteLine("Вычисление значения функции Y");
            Console.WriteLine("==============================");

            // Ввод значения X от пользователя
            Console.Write("Введите значение X: ");
            double x = double.Parse(Console.ReadLine());

            double y = 0;

            // Вычисление значения функции Y с использованием вложенных операторов if-else
            if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12;
            }
            else if (x > 0)
            {
                if (x < 5)
                {
                    y = Math.Sin(x) + Math.Cos(x);
                }
                else if (x >= 5 && x < 10)
                {
                    y = Math.Cos(x) - Math.Sin(x);
                }
                else
                {
                    y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
                }
            }
            else // x < 0
            {
                if (x > -12)
                {
                    y = 1 + (3 / Math.Pow(x, 2));
                }
                else // x <= -12
                {
                    y = x + 10 * x - (5 / x);
                }
            }

            // Округление до трех знаков после запятой
            y = Math.Round(y, 3);

            // Вывод результата
            Console.WriteLine("==============================");
            Console.WriteLine($"При x = {x}");
            Console.WriteLine($"y = {y}");

            Console.WriteLine("==============================");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}