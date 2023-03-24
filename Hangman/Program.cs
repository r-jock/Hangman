namespace Hangman
{
    internal class Program
    {
        static char[] word;
        static bool[] guess;
        static int misstake;

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

        static int countLetter(char c)
        {
            int count = 0;
            for(int i = 0;i<word.Length; i++)
            {
                if (word[i]== c)
                {
                    guess[i] = true;
                    count++;
                }
            }
            return count;
        }

        static bool won()
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (!guess[i])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            
            init("Word");
            getWord();
            do
            {
                char c = Console.ReadKey(true).KeyChar;
                countLetter(c);
                getWord();

            } while (!won());
            
            Console.ReadKey();
        }
    }
}