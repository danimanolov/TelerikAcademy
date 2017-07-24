using System;

namespace Sub-StringInText
{
    class Program
    {
        static int subStringOccurances(char[] substringToCheck, char[] text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if(substringToCheck[0] == text[i])
                {
                    for (int j = 1; j < substringToCheck.Length; j++)
                    {
                        if(substringToCheck[j] != text[i+j])
                        {
                            break;
                        }
                        else if(j == substringToCheck.Length - 1)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string inputSubString = Console.ReadLine();
            string inputText = Console.ReadLine();
            int output = subStringOccurances(inputSubString.ToLower().ToCharArray(), inputText.ToLower().ToCharArray());
            Console.WriteLine(output);
        }
    }
}
