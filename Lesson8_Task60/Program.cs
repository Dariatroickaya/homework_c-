// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Представь, что твой массив это кубик XYZ , 
// главной гранью , пусть будет X- высота, 
// остальные грани соединяются с X - Y,Z. 
// ПУСТЬ X ИМЕЕТ ВЫСОТУ равную 2 блокам памяти 
// в каждом из которых хранится 1 число, пусть 1 и 3, 
// Y = 2 блокам памяти, 4 и 5 (числа) 
// Z = 2 блокам памяти, 7 и 8 (числа) 
// Тогда первому блоку памяти X соответствует первые блоки памяти Y, Z 
// Тогда все будет выглядеть вот так XY [1,4] XZ [1,7]


Console.Write("Для создания массива X*Y*Z введите X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Для создания массива X*Y*Z введите Y: ");
int y = int.Parse(Console.ReadLine());

Console.Write("Для создания массива X*Y*Z введите Z: ");
int z = int.Parse(Console.ReadLine());

int[,,] array3D = new int[x, y, z];

FillArray(array3D);
PrintArray(array3D);


void FillArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}


void PrintArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}