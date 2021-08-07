namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            var end = "руб.";
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            if ( (count % 100 >= 11 && count % 100 <= 19) || (count % 10 >= 5 && count % 10 <= 9) || count % 10 == 0)
            {
                end = "рублей";
            }
            else if (count % 10 == 1)
            {
                end = "рубль";
            }
            else
            {
                end = "рубля";
            }
            return end;
        }
    }
}