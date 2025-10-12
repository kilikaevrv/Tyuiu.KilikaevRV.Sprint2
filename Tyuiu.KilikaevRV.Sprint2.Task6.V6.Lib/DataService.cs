namespace Tyuiu.KilikaevRV.Sprint2.Task6.V6.Lib;
using tyuiu.cources.programming.interfaces.Sprint2; 

    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndSuit(int m, int k)
        {
            // Используем сокращенную форму switch (switch expressions) для достоинства карты
            string cardName = k switch
            {
                6 => "Шестерка",
                7 => "Семерка",
                8 => "Восьмерка",
                9 => "Девятка",
                10 => "Десятка",
                11 => "Валет",
                12 => "Дама",
                13 => "Король",
                14 => "Туз",
                _ => "Неизвестная карта"
            };

            // Используем сокращенную форму switch (switch expressions) для масти карты
            string cardSuit = m switch
            {
                1 => "пик",
                2 => "треф",
                3 => "бубен",
                4 => "червей",
                _ => "неизвестной масти"
            };

            // Если одно из значений неизвестно, возвращаем сообщение об ошибке
            if (cardName == "Неизвестная карта" || cardSuit == "неизвестной масти")
            {
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
