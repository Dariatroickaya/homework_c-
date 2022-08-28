// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// ЭТУ ЗАДАЧУ САМА РЕШИТЬ НЕ СМОГЛА
// Ваш скопированный код тоже не запускается. Не понимаю, где ошибка

using System;

namespace Seminar3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = new Random().Next(1, 100000);
            static void ViewaThirdNumber1(int num, int index)
        {
            if (num > 99)
            {
                int length = (int)Math.Log10(num) + 1;

                int numberPow = (int)Math.Pow(10, length - index);

                int result = num / numberPow % 10;

                Console.WriteLine($"{index} цифра в числе {num} -> {result}");
            }
            else
                Console.WriteLine($"У числа нет трёх цифр");
        }
        }
    }
}