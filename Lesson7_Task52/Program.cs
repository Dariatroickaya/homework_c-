// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 void Average()
        {
            int[,] array = new int[3,4] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};
 
            for (int j = 0; j < 4; j++) 
            {
                int average = 0;
                for (int i = 0; i < 3; i++)
                {
                    average += array[i, j];
                    
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)average/3}");
                
            }
        }
    Average();


//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

// Console.Clear();

// Console.Write("Введите количество строк массива: ");
//  rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
//  columns = int.Parse(Console.ReadLine());

//  array = GetArray(rows, columns, 0, 10);

// PrintArray(array);

// double[] averageColumns = GetResultArray(array);
// Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",averageColumns)}");





// double[] GetResultArray(int[,] array)
// {
//     double[] result = new double[array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum=0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum+=array[j,i];
//         }
//         result[i]=Math.Round(sum/array.GetLength(0),2);
//     }
//     return result;
// }

