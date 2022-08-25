// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());

int index = 2;

while (index <= number)
{
    Console.Write($"{index}, ");
    index += 2;
}
