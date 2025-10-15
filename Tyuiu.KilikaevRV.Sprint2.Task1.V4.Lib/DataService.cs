

using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;


    
    
    
    
    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Используем все требуемые операции по одному разу в правильной последовательности
            // Операции сравнения: =, !=, <, >, <=, >= (по одному разу каждую)
            // Логические операции: !, &, ||, &&, ^ (по одному разу каждую)

            // 1: =, !=, &
            result[0] = (a == b) & (c != d);

            // 2: <, >, ||
            result[1] = (a < c) || (b > d);

            // 3: <=, >=, &&
            result[2] = (c <= a) && (d >= b);

            // 4: !, ^
            result[3] = !(a != b) ^ (c == d);

            // 5: арифметические выражения с <, >, &
            result[4] = (a + b) < (c - d) & (a * 2) > b;

            // 6: комбинация оставшихся операций
            result[5] = !((a <= c) || (b >= d)) && (a != b);

            return result;
        }
    }
}
        throw new NotImplementedException();
    }
}
