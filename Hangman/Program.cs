namespace Hangman
{
    internal class Program
    {
        static char[] word;
        static bool[] guess;

        static void init(string s)
        {
            word = s.ToCharArray();
            guess = new bool[word.Length];
        }

        static void getWord()
        {
            for(int i = 0;i<word.Length; i++)
            {
                if (!guess[i]) Console.Write("_ ");
                else Console.Write(word[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            init("Word");
            getWord();
            
            Console.ReadKey();
        }
    }
}