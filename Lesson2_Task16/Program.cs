// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет



//Без метода

// Console.WriteLine("Enter number1: ");
// int number1 = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Enter number2: ");
// int number2 = Convert.ToInt32 (Console.ReadLine());

// if(number1*number1 == number2)
// {
//     Console.WriteLine("ДА");    
// }
// else if(number2*number2 == number1)
// {
//     Console.WriteLine("ДА"); 
// }
// else 
// {
//     Console.WriteLine("НЕТ");
// }


using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareEachOther();
        }

        static void SquareEachOther()
        {
            Console.WriteLine("Enter number1: ");
            int number1 = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Enter number2: ");
            int number2 = Convert.ToInt32 (Console.ReadLine());

            if(number1*number1 == number2)
            {
                Console.WriteLine("ДА");    
            }
            else if(number2*number2 == number1)
            {
                Console.WriteLine("ДА"); 
            }
            else 
            {
                Console.WriteLine("НЕТ");
            }
        }

    }
}