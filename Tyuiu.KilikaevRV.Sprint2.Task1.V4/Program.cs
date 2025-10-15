using System;
using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Test.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Test;
using System;
using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;

class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tyulu.KilikaevRV.Sprint4.Task4.V4";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Tyulu.KilikaevRV.Sprint4.Task4.V4                                      *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* Генерация логической последовательности                                *");
            Console.WriteLine("* Выполнил: Килияев Р.В. | АСОиУб-23-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int a = 175, b = 176, c = 414, d = 414;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.Write("Логическая последовательность: (");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i < result.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(")");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ожидаемая последовательность: (False, False, False, False, True, False)");

            // Проверка соответствия ожидаемому результату
            bool[] expected = { false, false, false, false, true, false };
            bool isCorrect = true;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != expected[i])
                {
                    isCorrect = false;
                    break;
                }
            }

            Console.WriteLine($"Результат корректный: {isCorrect}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
