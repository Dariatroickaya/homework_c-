// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
          Palindrome();
        }

        static void Palindrome()
        {     
           Console.Write("Введите положительное пятизначное число: ");
           int number = int.Parse(Console.ReadLine());

           if(number >= 10000 && number < 100000)
           {
                int a = number / 10000;
                int b = number % 10000 / 1000;
                int c = number % 1000 / 100;
                int d = number % 100 / 10;
                int e = number % 10;    

                if(a == e && b == d)
                {
                    Console.WriteLine("Да, это число является палиндромом");
                }

                else
                {
                    Console.WriteLine("Нет, это число не является палиндромом");
                }
           }

           else
           {
                Console.WriteLine("Введено неверное число");
           }
        }
    }
}