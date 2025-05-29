

namespace Palindrome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (string word in args)
            {
                if (word == null)
                {
                    Console.WriteLine("Error: String cannot be null");
                    continue;
                }

                bool result = IsPalindrome(word);
                Console.WriteLine($"{word} -> {result}");
            }
        }

        public static bool IsPalindrome(string word)
        {
            if (word == null)
            {
                throw new ArgumentException("String cannot be null");
            }

            if (word.Length < 2)
            {
                return true;
            }

            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string reversedWord = new string(chars);

            return word == reversedWord;
        }
    }
}