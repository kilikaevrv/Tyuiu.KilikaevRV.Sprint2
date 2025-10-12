using System;
using Tyuiu.KilikaevRV.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Килияев Р. В. | ИИПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Сокращенная форма оператора switch                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Килияев Роман Валерьевич | ИИПБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи        *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.   *");
            Console.WriteLine("* По заданным номеру масти m (1 <= m <= 4) и номеру достоинства карты k   *");
            Console.WriteLine("* (6 <= k <= 14) определить полное название карты.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("Масти карт:");
            Console.WriteLine("1 - пики");
            Console.WriteLine("2 - трефы");
            Console.WriteLine("3 - бубны");
            Console.WriteLine("4 - червы");
            Console.WriteLine();
            Console.WriteLine("Достоинства карт:");
            Console.WriteLine("6  - Шестерка");
            Console.WriteLine("7  - Семерка");
            Console.WriteLine("8  - Восьмерка");
            Console.WriteLine("9  - Девятка");
            Console.WriteLine("10 - Десятка");
            Console.WriteLine("11 - Валет");
            Console.WriteLine("12 - Дама");
            Console.WriteLine("13 - Король");
            Console.WriteLine("14 - Туз");
            Console.WriteLine();

            Console.Write("Введите номер масти m (1-4): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер достоинства карты k (6-14): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindCardNameAndSuit(m, k);
            Console.WriteLine($"Полное название карты: {result}");

            Console.ReadKey();
        }
    }
}