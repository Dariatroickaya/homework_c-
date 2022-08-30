// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


//ВАРИАНТ 1

// Console.WriteLine("Enter three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int number1 = number % 10;

// int number2 = number-number1;

// int result = (number2 % 100)/10;

// Console.WriteLine(result);


//ВАРИАНТ 2

// int number = new Random().Next(100, 1000);

// int number1 = number % 10;

// int number2 = number-number1;

// int result = (number2 % 100)/10;

// Console.WriteLine(number);

// Console.WriteLine(result);



//ВАРИАНТ 3

using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSecondNumber();
        }

        static void FindSecondNumber()
        {
           int number = new Random().Next(100, 1000);

            int number1 = number % 10;

            int number2 = number-number1;

            int result = (number2 % 100)/10;

            Console.WriteLine(number);

            Console.WriteLine(result); 
        }
    }

}


//Решение преподавателя

// static void ViewsecondNumber(int num)
// {
//     if (num>99 && num<1000)
//     {
//         int secondNumber = num / 10 % 10;

//         Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
//     }
//     else
//         Console.WriteLine($"Число {num} не трехзначное");
// }
//     }
// }