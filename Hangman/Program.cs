namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Wordlist = { "Banane", "Auto", "Käsekuchen", "Pflaumenkuchen" };
            string searchedWord = ""; // Variable to save the founded Letters
            string selectedWord = ""; // Variable to save the Random Word
            Random ranWord = new Random(); // New Randomgenerator
            int Rword = ranWord.Next(0, Wordlist.Length); // Generates a Random number from the Length of the Array "Wordlist"
            selectedWord = Wordlist[Rword].ToLower();
            Console.WriteLine(selectedWord);
            for (int i = 0;i < selectedWord.Length; i++)
            {
                searchedWord = searchedWord + '_';
            }
            Console.Write(searchedWord);
            Console.ReadKey();

        }
    }
}