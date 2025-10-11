
    using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KilikaevRV.Sprint2.Task3.V8.Lib
    {
        public class FunctionCalculator : ISprint2Task3V8
        {
            /// <summary>
            /// Вычисляет значение функции Y для заданного X
            /// </summary>
            /// <param name="x">Аргумент функции</param>
            /// <returns>Значение функции Y, округленное до 3 знаков после запятой</returns>
            public static double CalculateFunction(double x)
            {
                double y;

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

                return Math.Round(y, 3);
            }

        public double Calculate(double x)
        {
            throw new NotImplementedException();
        }
    }
    }
