namespace RANDOM_GENERATOR
{
    internal class randomSentenceGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Ivailo", "Vankata", "Anton","Bencho-Bencev","Dimitar","Deqn","Mariq" };
            string[] places = { "Sofia", "Burgas", "Varna", "Plovdiv", "Kardjali", "Xaskovo", "Popovo", };
            string[] verbs = {"eats","holds","sees","playe whit","brings","lost","swiming", };
            string[] nouns = {"stones","cake","apple","laptop","bikes","cars","boll","umbrella" };
            string[] adverbs = {"slowly","diligently","warmly","sadly","rapidly" };
            string[] details = {"near the river","at home","in the park","in the stadium","in the cars", };
            Console.WriteLine("Hello,this is yours first random-generated sentence:");
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
                string who = $"{randomName} from {randomPlaces}";
                string action = $"{randomAdverbs} {randomVerbs} {randomNouns}";
                string sentence = $"{who} {action} {randomDetails}";
                Console.WriteLine(sentence);
                Console.WriteLine();
                Console.WriteLine("Click[Enter} to generated new one!");
                Console.ReadLine();

            }
            
        }

        static string GetRandomWord(string[]names)
        {
            Random random = new Random();
            int randomIndex = random.Next(0, names.Length);
            string words = names[randomIndex];
            return words;
        }
    }
}