// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

// БЕЗ МЕТОДА
// Console.WriteLine("Enter number:");
// int number = Convert.ToInt32(Console.ReadLine());


// if((number % 7 == 0) && (number % 23 == 0))
// {
//     Console.Write("YES");
// }
// else 
// {
//     Console.Write("NO");
// }


using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            SimultaneousMultiplicity();
        }

        static void SimultaneousMultiplicity()
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if((number % 7 == 0) && (number % 23 == 0))
            {
                Console.Write("YES");
            }
            else 
            {
                Console.Write("NO");
            }
        }

    }
}