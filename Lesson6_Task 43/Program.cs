// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// Решение: Для вычисления координат точки пересечения прямых, решим систему уравнений:

// Вычтем из первого уравнения второе
// (y = k1 * x + b1)  -  (y = k2 * x + b2)
// y-y = (k1 * x + b1) - (k2 * x + b2)
// 0 = k1 * x + b1 - k2 * x - b2

// Из первого уравнения найдем значение x
// k1 * x - k2 * x = b2 - b1
// x * (k1 - k2) = b2 - b1
// x = (b2 - b1) / (k1 - k2)

// Подставим значение x во второе уравнение и найдем значение y
// y = k2 * x + b2 = k2 * (b2 - b1) / (k1 - k2) + b2

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
 
var x = (b2 - b1) / (k1 - k2);
var y = k2 * x + b2;
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");