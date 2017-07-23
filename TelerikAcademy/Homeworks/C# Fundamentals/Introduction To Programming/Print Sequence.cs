using System;

namespace GitHub_All_Homeworks_Done
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine("-{0}", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
