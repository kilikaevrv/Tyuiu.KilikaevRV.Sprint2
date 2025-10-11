using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KilikaevRV.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndSuit(int value, int suit)
        {
            string cardName = "";
            string cardSuit = "";

            // Определяем достоинство карты с помощью switch
            switch (value)
            {
                case 6:
                    cardName = "Шестерка";
                    break;
                case 7:
                    cardName = "Семерка";
                    break;
                case 8:
                    cardName = "Восьмерка";
                    break;
                case 9:
                    cardName = "Девятка";
                    break;
                case 10:
                    cardName = "Десятка";
                    break;
                case 11:
                    cardName = "Валет";
                    break;
                case 12:
                    cardName = "Дама";
                    break;
                case 13:
                    cardName = "Король";
                    break;
                case 14:
                    cardName = "Туз";
                    break;
                default:
                    cardName = "Неизвестная карта";
                    break;
            }

            // Определяем масть карты с помощью switch
            switch (suit)
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
                    cardSuit = "неизвестной масти";
                    break;
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