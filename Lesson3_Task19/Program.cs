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



//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

//   public static bool IsPalindromeInt(int num)
//         {
//             // num = 456654
//             int temp = num;
//             // temp = 456654
//             int revert = 0;

//             while (temp > 0)
//             {
//                 //revert= 0*10=0 + 4=4
//                  //revert= 4*10=40 + 5=45
//                  //revert= 45*10=450 + 6=456
//                  //revert= 456*10=4560 + 6=4566
//                  //revert= 4566*10=45660 +5=45665
//                  //revert= 45665*10=456650 + 6=456654
//                 revert = (revert * 10) + (temp % 10); 
//                 //temp = 45665
//                 //temp = 456
//                 //temp = 45
//                 //temp = 4
//                 temp /= 10;
//             }

//             return revert == num;
//         }

//         public static bool IsPalindromeString(string str)
//         {
//             int size = str.Length;
//             for (int i = 0; i <= size / 2; ++i)
//             {
//                 if (str[i] != str[size - 1 - i])
//                 {
//                     return false;
//                 }
//             }
//             return true;
//         }