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
                Console.WriteLine();
                int sum = countLetter(c);
                if (sum == 0) misstake++;
                Console.Clear();
                Console.WriteLine("Your Letter "+ c + " is " + sum + " in this word!");
                Console.WriteLine("Miss Guesses: " + misstake);
                getWord();

            } while (!won() && misstake <=10);

            if (!won())
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU LOSE!");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("YOU WIN!");
                Console.ResetColor();
            }
            
            Console.ReadKey();
        }
    }
}