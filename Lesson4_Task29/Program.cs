// Задача 29: Напишите программу, которая задаёт массив из введенного числа 
//            и выводит их на экран. пользователь вводит число элементов в массиве и 
//            минимальное, и максимальное значение . 
// надо заполнить массив рандомными данными от минимального до максимального значение .
// И важное уточнениее , делать все в методе который возвращает массив

// 5, 1, 20 -> [1, 2, 5, 7, 19]

// 3, 1, 33 -> [6, 1, 33]



int[] CreateArray()

{
    Console.Write("Введите число элементов массива:");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное число:");
    int minnumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное число:");
    int maxnumber = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[number];

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minnumber , maxnumber+1);
        }

    Console.WriteLine(String.Join(",", array));

    return array;
}

CreateArray();
