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
    
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      result = result + (number % 10);
      number = number / 10;
    }
   return result;
  }


//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ
// void SumNumbers()
// {
//     Console.Clear();

//     int num = SetNumber("N");
//     Console.WriteLine($"Суммф цифр = {GetSumNums(num)}");
// }


// int GetSumNums(int number)
// {
//     int sum = 0;

//     while (number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }

//     return sum;
// }