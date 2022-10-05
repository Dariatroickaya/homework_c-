// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.WriteLine("Введите число m больше ноля: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n больше ноля: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Числа не соответствуют условию");
}

else 
{ if (m == n)
    {
        Console.WriteLine("Числа равны между собой");
    }

  else 
    {if (m > n)
        {
            int number = n;
            while (number <= m)
                {
                Console.Write($"{number}, ");
                number++;
                }
        }
     else
        {
            int number = m;
            while (number <= n)
            {
            Console.Write($"{number}, ");
            number++;
            }
        }
    }
}