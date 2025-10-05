using Tyuiu.KilikaevRV.Sprint1.Task0.V8.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 185;
            int y = 251;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetCompareOperations(x, y);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Последовательность операций:");
            Console.WriteLine($"x == 185    -> {result[0]}");
            Console.WriteLine($"1 == y      -> {result[1]}");
            Console.WriteLine($"x < y       -> {result[2]}");
            Console.WriteLine($"x > y       -> {result[3]}");
            Console.WriteLine($"x <= y      -> {result[4]}");
            Console.WriteLine($"x >= y      -> {result[5]}");

            Console.ReadKey();
        }
    }
}