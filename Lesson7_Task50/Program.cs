// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[rows, columns];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(0,100);
        }  
}
 


for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
       { 
         Console.Write($"{array[i,j]} ");
        // Console.Write(array[i,j] + "\t  ");     
       }
    Console.WriteLine();
}



Console.Write("Введите индекс строки искомого элемента: ");
int indexrows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца искомого элемента: ");
int indexcolumns = Convert.ToInt32(Console.ReadLine());

if (indexrows > rows || indexcolumns > columns)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    //object find = array.GetValue(indexrows,indexcolumns);  
    //Console.WriteLine(find);
    Console.WriteLine(array[indexrows,indexcolumns]);
}


//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ
// Console.Clear();

// Console.Write("Введите количество строк массива: ");
//  rows=int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
//  columns=int.Parse(Console.ReadLine());


// int[,] array = GetArray(rows, columns,0,10);
// PrintArray(array);
// Console.Write("Введите значение элемента: ");
// int element=int.Parse(Console.ReadLine());
// if(FindElement(array,element))
// {
//     Console.WriteLine("Элемент найден");
// }
// else
// {
//     Console.WriteLine("Элемент не найден");
// }

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// bool FindElement(int[,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j]==el) return true;
//         }
//     }
//     return false;
// }