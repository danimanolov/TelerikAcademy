using System;

namespace CheckBrackets
{
    class Program
    {
        static string checkBrackets(char[] input)
        {
            char leftBracket = '(';
            char rightBracket = ')';
            int leftBracketCount = 0;
            int rightBracketCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(leftBracketCount >= rightBracketCount)
                {
                    if (input[i] == leftBracket)
                    {
                        leftBracketCount++;
                    }
                    else if (input[i] == rightBracket)
                    {
                        rightBracketCount++;
                    }
                }
                else
                {
                    break;
                }
            }
            if(leftBracketCount == rightBracketCount)
            {
                return "Correct";
            }
            else
            {
                return "Incorrect";
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(checkBrackets(input.ToCharArray()));
        }
    }
}
