using System;

namespace ReverseString
{
    class Program
    {
        static char[] reverseStringWithLoops(char[] input)
        {
            char temp = ' ';
            for (int i = 0; i < input.Length/2; i++)
            {
                temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
            return input;
        }
        static string reverseStringWithBuiltInImplementation(string input)
        {
            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            return new string (temp);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLinereverseStringWithBuiltInImplementation(input));
	    Console.WriteLine(reverseStringWithLoops(char[] input.ToCharArray());

        }
    }
}
