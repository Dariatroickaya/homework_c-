// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//  NumberToThePower


// Console.WriteLine("введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Function(numberA , numberB);

// void Function(int numberA, int numberB)
// {
//     Console.WriteLine($"{numberA} , {numberB} -> {Math.Pow(numberA,numberB)}");
// }


Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = NumberToThePower(numberA, numberB);
Console.WriteLine(result);


int NumberToThePower(int numberA, int numberB)
    {
        int result = 1;

        for(int i=1; i <= numberB; i++)
            {
                result = result * numberA;
            }

        return result;
    }



//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

//   void MyPow()
// {

//     Console.Clear();

//     int num = SetNumber("");

//     int degree = SetNumber("degree of");

//     Console.WriteLine($"{num} в степени {degree} = {Pow(num, degree)}");
// }



// int Pow(int num, int rank)
// {
//     if (rank == 0) return 1;
//     else if (rank == 1) return num;

//     int result = num;

//     for (int i = 2; i <= rank; i++)
//     {
//         result *= num;
//     }

//     return result;
// }