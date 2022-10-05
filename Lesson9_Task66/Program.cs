// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число m больше ноля: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n больше: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Введенные числа не соответствуют условию");
}

else 
{ if (m == n)
    {
        Console.WriteLine($"-> {m+n}");
    }

  else 
    {if (m > n)
        {
            int number = n;
            int sum = 0;
            while (number <= m)
                {
                 sum = sum+number; 
                 number++;
                }
            Console.Write($"-> {sum}");
        }
     else
        {
            int number = m;
            int sum = 0;
            while (number <= n)
                {
                 sum = sum+number; 
                 number++;
                }
            Console.Write($"-> {sum}");
            }
    }
}
