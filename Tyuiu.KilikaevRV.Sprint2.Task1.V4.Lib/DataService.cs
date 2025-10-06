using tyuiu.cources.programming.interfaces.Sprint2;

using System;

namespace Tyuiu.KilkaevRV.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] Calculate()
        {
            bool[] result = new bool[6];

            // Используем операции сравнения и логические операции
            // для получения последовательности [false, false, false, false, true, false]

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            // Операция 1: false
            result[0] = (a > b) && (c < d);  // (1 > 2) && (3 < 4) = false && true = false

            // Операция 2: false  
            result[1] = (a == b) || (c != c); // (1 == 2) || (3 != 3) = false || false = false

            // Операция 3: false
            result[2] = (a + b) < (c - d);   // (1 + 2) < (3 - 4) = 3 < -1 = false

            // Операция 4: false
            result[3] = !(a < b) & (c > d);  // !(1 < 2) & (3 > 4) = !true & false = false & false = false

            // Операция 5: true
            result[4] = (a != b) ^ (c == c); // (1 != 2) ^ (3 == 3) = true ^ true = false → нужно true
            // Исправляем:
            result[4] = (a != b) ^ (c != c); // (1 != 2) ^ (3 != 3) = true ^ false = true

            // Операция 6: false
            result[5] = (a >= b) || (c <= d); // (1 >= 2) || (3 <= 4) = false || true = true → нужно false
            // Исправляем:
            result[5] = (a >= b) || (c > d);  // (1 >= 2) || (3 > 4) = false || false = false

            return result;
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}