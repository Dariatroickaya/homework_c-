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
        Console.Write(array[i,j] + "\t  ");     // В этом месте мне помогли, я не очень понимаю, что это вообще и зачем
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
    object find = array.GetValue(indexrows,indexcolumns);  // в этом месте мне тоже помогли. буду ждать вашего решения и обьяснения на семинаре
    Console.WriteLine(find);
}