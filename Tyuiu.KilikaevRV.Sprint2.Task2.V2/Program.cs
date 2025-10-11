using System;

using Tyuiu.KilikaevRV.Sprint2.Task2.V2.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tyulu.KilikaevRY.Sprint2.Task1.V2");
            Console.WriteLine("Вариант 2");
            Console.WriteLine("Проверка нахождения точки в заштрихованной области");
            Console.WriteLine("==============================");

            // Ввод координат от пользователя
            Console.Write("Введите координату X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            int y = int.Parse(Console.ReadLine());

            // Проверка нахождения в различных областях
            bool inArea1 = CheckArea1(x, y);  // Область 1: круг радиусом 5 в центре (0,0)
            bool inArea2 = CheckArea2(x, y);  // Область 2: прямоугольник от (-3,-3) до (3,3)
            bool inArea3 = CheckArea3(x, y);  // Область 3: кольцо между радиусами 2 и 4

            // Вывод результатов
            Console.WriteLine("==============================");
            Console.WriteLine($"Координаты точки: ({x}, {y})");
            Console.WriteLine($"Находится в области 1 (круг R=5): {inArea1}");
            Console.WriteLine($"Находится в области 2 (квадрат 6x6): {inArea2}");
            Console.WriteLine($"Находится в области 3 (кольцо R2-R4): {inArea3}");
            Console.WriteLine($"Находится в заштрихованной области: {inArea1 || inArea2 || inArea3}");

            Console.WriteLine("==============================");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Область 1: круг радиусом 5 с центром в (0,0)
        static bool CheckArea1(int x, int y)
        {
            return (x * x + y * y) <= 25;  // x² + y² ≤ R², где R=5
        }

        // Область 2: квадрат от (-3,-3) до (3,3)
        static bool CheckArea2(int x, int y)
        {
            return Math.Abs(x) <= 3 && Math.Abs(y) <= 3;
        }

        // Область 3: кольцо между радиусами 2 и 4
        static bool CheckArea3(int x, int y)
        {
            double distanceSquared = x * x + y * y;
            return distanceSquared >= 4 && distanceSquared <= 16;  // 2² ≤ r² ≤ 4²
        }
    }
}