// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


//Без метода

// Console.Write("Enter number 1 to 7: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if((number > 0) && (number < 6))
// {
//     Console.WriteLine("НЕТ");
// }
// else if ((number > 5) && (number < 8))
// {
//     Console.WriteLine("ДА");
// }
// else
// {
//     Console.WriteLine("НЕВЕРНОЕ ЧИСЛО");
// }





using System;

namespace Seminar2
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfTheWeek();
        }

        static void DayOfTheWeek()
        {
          Console.Write("Enter number 1 to 7: ");
          int number = Convert.ToInt32(Console.ReadLine());

          if((number > 0) && (number < 6))
            {
              Console.WriteLine("НЕТ");
            }
          else if ((number > 5) && (number < 8))
              {
                Console.WriteLine("ДА");
              }
              else
              {
                Console.WriteLine("НЕВЕРНОЕ ЧИСЛО");
              }
        }

    }
}