// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов в массиве");
    int number = Convert.ToInt32(Console.ReadLine());

    int[] array = new int [number];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }

    Console.WriteLine(String.Join("," , array));
    return array;
}
//CreateArray();

int SumOddPositions(int[] array)
{
    int result = 0;

    for(int i = 1; i < array.Length; i+=2)
    {
        result = result + array[i];
    }

    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях:" +result);
    return result;
}

SumOddPositions(CreateArray());