// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// m = 3, n = 4.

// 0,5    7    -2    -0,2
 
// 1    -3,3    8    -9,9

// 8     7,8  -7,1     9


Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = FillArray(rows, columns);
PrintArray(array);

double[,] FillArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble()*10;
        }
    }
    return result;
}


void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}






//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
// int rows=int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=int.Parse(Console.ReadLine());

// double[,] arrayDouble = GetArrayDouble(rows, columns, 0, 10);
// PrintArrayDouble(arrayDouble);

// double[,] GetArrayDouble(int m, int n, int min, int max)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*(max-min);
//         }
//     }
//     return result;
// }

// void PrintArrayDouble(double[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }
