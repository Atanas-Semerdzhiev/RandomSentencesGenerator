namespace BG_RANDOM__GENERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ивчо", "Тошко", "Талия", "Чинар", "Маркова", "Стоянова", "Ели", "Елена" };
            string[] places = { "Веселчани", "Гледка", "Студен Кладенец", "Възрожденци", "Резбарци", "Пазара" };
            string[] verbs = { "яде", "държи", "вижда", "играе със", "носи", "изгуби", "плува", };
            string[] nouns = { "камък", "торта", "ябълка", "лаптоп", "колело", "кола", "топка", "чадър" };
            string[] adverbs = { "бавно", "усърдно", "топло", "тъжно", "бързо" };
            string[] details = { "близо до реката", "у дома", "в парка", "на стадиона", "в колата", };
            Console.WriteLine("Здравейтер,това е първи случаен Генератор на Комбинации");
            Console.WriteLine();
            Console.WriteLine();
            string command;
            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlaces = GetRandomWord(places);
                string randomVerbs = GetRandomWord(verbs);
                string randomNouns = GetRandomWord(nouns);
                string randomAdverbs = GetRandomWord(adverbs);
                string randomDetails = GetRandomWord(details);
                string who = $"{randomName} от {randomPlaces}";
                string action = $"{randomAdverbs} {randomVerbs} {randomNouns}";
                string sentence = $"{who} {action} {randomDetails}";
                Console.WriteLine(sentence);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Натисни[Enter} за да генерираш нова комбинация!");
                Console.ReadLine();
                Console.WriteLine();
            }
        }
        static string GetRandomWord(string[] names)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, names.Length);
            string words = names[randomIndex];
            return words;
        }
    }
}