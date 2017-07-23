using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dateOfBirth = Console.ReadLine().Split('.');
            int age = 0;
            int todayYear = 2016;
            int todayMonth = 12;
            int todayDay = 30;
            if(todayMonth < int.Parse(dateOfBirth[0]))
            {
                age = todayYear - int.Parse(dateOfBirth[2]) -1;
            }
            else if(todayMonth == int.Parse(dateOfBirth[0]) && todayDay < int.Parse(dateOfBirth[1]))
            {
                age = todayYear - int.Parse(dateOfBirth[2]) - 1;
            }
            else
            {
                age = todayYear - int.Parse(dateOfBirth[2]);
            }
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
