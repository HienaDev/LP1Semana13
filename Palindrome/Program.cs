using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string word in args)
                Console.WriteLine(CheckIfP(word));

        }

        static private bool CheckIfP(string word)
        {
            
            bool CheckForP(string s)
            {
                char[] phrase = s.ToCharArray();
                Array.Reverse(phrase);
                string temp = "";

                foreach (char c in phrase)
                {
                    temp += c;
                }
                if (s == temp)
                    return true;
                else
                    return false;
            }

            if (word == null)
            {
                throw new ArgumentNullException();
            }
            else if (word.Length == 1 )
                return true;
            else
            {
                return (CheckForP(word));
            }
        }
    }
}
