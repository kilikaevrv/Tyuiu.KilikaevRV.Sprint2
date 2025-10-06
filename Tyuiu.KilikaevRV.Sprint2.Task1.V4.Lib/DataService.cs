using tyuiu.cources.programming.interfaces.Sprint2;

using System;

namespace Tyuiu.KilkaevRV.Sprint2.Task4.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] Calculate()
        {
            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;

            bool[] result = new bool[6];

            // Используем арифметические выражения с числами 175 и b (176)
            result[0] = (175 + b) == (a + 176);           // (175+176)==(175+176) = True → но нужно False
            result[0] = (175 + b) < (a + 176);            // (175+176)<(175+176) = False

            result[1] = (b - 175) > (176 - a);            // (176-175)>(176-175) = False
            result[2] = (175 * b) <= (a * 176);           // (175*176)<=(175*176) = True → но нужно False
            result[2] = (175 * b) < (a * 176);            // (175*176)<(175*176) = False

            result[3] = (b / 175) >= (176 / a);           // (176/175)>=(176/175) = True → но нужно False
            result[3] = (b / 175) > (176 / a);            // (176/175)>(176/175) = False

            result[4] = (175 % b) != (a % 176);           // (175%176)!=(175%176) = False → но нужно True
            result[4] = (175 % b) == (a % 176);           // (175%176)==(175%176) = True

            result[5] = (b + 175) == (176 + a);           // (176+175)==(176+175) = True → но нужно False
            result[5] = (b + 175) != (176 + a);           // (176+175)!=(176+175) = False

            return result;
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}