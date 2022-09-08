// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76




void DifferenceMaxMin()
{
    Console.Write("Введите количество элементов в массиве: ");
    int number = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[number];
    double max = 0;
    double min = 1;

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();

        if(array[i] > max)
            {
                max = array[i];
            }
        
        if(array[i] < min)
            {
                min = array[i];
            }
        
    }

    Console.WriteLine($"[{String.Join("; " , array)}] -> {(max - min):f4}");
} 

DifferenceMaxMin();
