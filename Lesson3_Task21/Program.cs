// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

    // Расстояние между точками — это число, равное корню 
    // из суммы квадратов разностей координат точек или длине разности радиус-векторов точек

using System;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите X1: ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите Y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите Z1: ");
            int z1 = int.Parse(Console.ReadLine());

            Console.Write("Введите X2: ");
            int x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите Y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.Write("Введите Z2: ");
            int z2 = int.Parse(Console.ReadLine());

            DistanceBetweenPointsIn3D(x1, x2, y1, y2, z1, z2);
        }

        static void DistanceBetweenPointsIn3D(int x1, int x2, int y1, int y2, int z1, int z2)
        {
            Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> ");
            double DistanceBetweenPointsIn3D = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            // Console.WriteLine($"Distance Between Points in 3D={DistanceBetweenPointsIn3D:f2}");
            Console.Write($"{DistanceBetweenPointsIn3D:f2}");
        }
    }
}
