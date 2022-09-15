// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


//НЕ МОГУ НАЙТИ ОШИБКУ/ В МАССИВЕ 3 НА 3 РАБОТАЕТ, В 3 НА 4 НЕТ


// int[,] array = FillArray(3, 4, 0, 10);
// PrintArray(array);

// int[,] FillArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();

// void Average(int[,] array)
// {
//             for (int i = 0; i < 3; i++) 
//             {
//               int average = 0;
//               for (int j = 0; j < 4; j++)
//                 {
//                   average += array[j, i];

// System.Console.WriteLine(average);
//                 }
//                 // Console.WriteLine($"Cреднее арифметическое элементов столбца {i+1} = {(float)average/3}");
//             }
// }
// Average(array);


 void Average()
        {
            int[,] array = new int[3,3] {{1,4,7},{5,9,2},{8,4,2}};
 
            for (int i = 0; i < 3; i++) 
            {
                int average = 0;
                for (int j = 0; j < 3; j++)
                {
                    average += array[j, i];
                    
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)average/3}");
                
            }
        }
    Average();