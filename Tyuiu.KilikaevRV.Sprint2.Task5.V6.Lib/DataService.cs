using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KilikaevRV.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndSuit(int m, int k)
        {
            string cardName = "";
            string cardSuit = "";

            // Определяем достоинство карты k (6-14) с помощью switch
            switch (k)
            {
                case 6:
                    cardName = "шестерка";
                    break;
                case 7:
                    cardName = "семерка";
                    break;
                case 8:
                    cardName = "восьмерка";
                    break;
                case 9:
                    cardName = "девятка";
                    break;
                case 10:
                    cardName = "десятка";
                    break;
                case 11:
                    cardName = "валет";
                    break;
                case 12:
                    cardName = "дама";
                    break;
                case 13:
                    cardName = "король";
                    break;
                case 14:
                    cardName = "туз";
                    break;
                default:
                    return "Неизвестная карта неизвестной масти";
            }

            // Определяем масть карты m (1-4) с помощью switch
            switch (m)
            {
                case 1:
                    cardSuit = "пик";
                    break;
                case 2:
                    cardSuit = "треф";
                    break;
                case 3:
                    cardSuit = "бубен";
                    break;
                case 4:
                    cardSuit = "червей";
                    break;
                default:
                    return "Неизвестная карта неизвестной масти";
            }

            // Собираем полное название карты
            return $"{cardName} {cardSuit}";
        }

        public string FindCardNameAndValue(int value1, int value2)
        {
            throw new NotImplementedException();
        }
    }
}