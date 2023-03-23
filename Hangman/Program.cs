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
            Console.WriteLine(selectedWord); // For DEBUGGING

            for (int i = 0;i < selectedWord.Length; i++) // Iterate through the Selected Word
            {
                searchedWord = searchedWord + '_'; // replace the Letter of the Word with "_".
            }
            Console.Write(searchedWord); // Printed The Word as '_' on the Console

            Console.WriteLine("Gebe ein Buchstaben ein: ");
            string Mysuggestion = Console.ReadLine();
            string myWord = "";

            
            
            Console.ReadKey();

        }
    }
}