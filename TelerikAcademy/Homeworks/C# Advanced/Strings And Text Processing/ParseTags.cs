using System;

namespace Parse_Tags
{
    class Program
    {
        static string parseTags(char[] text)
        {
            char tagOpen = '<';
            for (int i = 0; i < text.Length; i++)
            {
                if (tagOpen == text[i])
                {
                    int j = i + 1;
                    while (text[j] != tagOpen)
                    {
                            text[j] = Char.ToUpper(text[j]);
                            j++;
                    }
                    i = j;
                }
            }
            return new string(text);
        }
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string output = parseTags(inputText.ToCharArray());
            output = output.Replace("</upcase>", string.Empty);
            output = output.Replace("<UPCASE>", string.Empty);
            Console.WriteLine(output);
        }
    }
}
