// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfNumbers(number);
Console.WriteLine(result);
 
 

int SumOfNumbers(int number)
  {
    int count = Convert.ToString(number).Length;
    int remainder = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      remainder = number - number % 10;
      result = result + (number - remainder);
      number = number / 10;
    }
   return result;
  }

