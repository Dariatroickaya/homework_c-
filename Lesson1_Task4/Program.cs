Console.WriteLine("Enter number1:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2:");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number3:");
int number3 = Convert.ToInt32(Console.ReadLine());

if((number1 > number2) && (number1 > number3))
{
    Console.WriteLine($"max = {number1}");
}
else if ((number2 > number1) && (number2 > number3))
{
    Console.WriteLine($"max = {number2}");
}
else
{
    Console.WriteLine($"max = {number3}");
}