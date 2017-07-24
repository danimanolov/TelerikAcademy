using System;

namespace StringLength
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char[] result = new char[20];
            char[] text = inputText.ToCharArray();
            for (int i = text.Length - 1; i < 20; i++)
            {
                result[i] = '*';
            }
            for (int j = 0; j < text.Length; j++)
            {
                result[j] = text[j];
            }
            string output = new string(result);
            Console.WriteLine(output);
        }
    }
}
