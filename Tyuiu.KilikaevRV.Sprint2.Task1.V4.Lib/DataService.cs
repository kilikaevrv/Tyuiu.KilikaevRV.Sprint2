

using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;


    public class DataService : ISprint2Task1V4
    {
        public bool[] Calculate(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Используем все требуемые операции по одному разу в правильной последовательности
            // Операции сравнения: =, !=, <, >, <=, >=
            // Логические операции: !, &, ||, &&, ^

            result[0] = (a == b) & (c != d);                    // =, !=, &
            result[1] = (a < c) || (b > d);                     // <, >, ||
            result[2] = (c <= a) && (d >= b);                   // <=, >=, &&
            result[3] = !(a != b) ^ (c == d);                   // !, !=, =, ^
            result[4] = (a + b) < (c - d) & (a * 2) > b;       // <, >, &, арифметические
            result[5] = !((a <= c) || (b >= d)) && (a != b);   // !, <=, >=, ||, &&, !=

            return result;
        }

    public bool[] GetLogicOperations(int a, int b, int c, int d)
    {
        throw new NotImplementedException();
    }
}
