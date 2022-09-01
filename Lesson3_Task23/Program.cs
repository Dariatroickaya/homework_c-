// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Введите число: ");
           int number = int.Parse(Console.ReadLine());

           CubeTable(number);
        }

        static void CubeTable(int number)
        {     
            Console.Write ($"{number} -> ");

            for (int i = 1; i <= number; i++)
            {
                Console.Write ($"{Math.Pow(i, 3)} ");
            }
        }
    }
}