
    using System;
    using tyuiu.cources.programming.interfaces.Sprint2;
    namespace Tyuiu.KilikaevRV.Sprint2.Task3.V8.Lib
    {
        public class DataService : ISprint2Task3V8
        {
            public double Calculate(double x)
            {
                double y;

                if (x > 0)
                {
                    y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
                }
                else if (x == 0)
                {
                    y = (x * x - Math.Cos(x * x) + 10);
                }
                else if (x > -12 && x < 0)
                {
                    y = Math.Pow(1 + (3 / Math.Pow(x, 2)), x);
                }
                else // x <= -12
                {
                    y = x + 10 * x - (5 / x);
                }

                return Math.Round(y, 3);
            }
        }
    }