
using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;

using tyuiu.cources.programming.interfaces.Sprint2;

    public class DataService : ISprint2Task1V4
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];


            result[0] = (a == b) & (c < d);


            result[1] = (a > b) && (c == d);


            result[2] = (b < a) || (d > c) && (a == c);


            result[3] = !(c == d) & (a <= b);


            result[4] = (c == d) && (b > a) || (d >= c);


            result[5] = (a >= b) | (c != d) && !(b < a);

            return result;
        }
    }
