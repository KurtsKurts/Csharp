// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координат xA :");
int xA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат yA :");
int yA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат zA :");
int zA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат xB :");
int xB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат yB :");
int yB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координат zB :");
int zB = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt((xA - xB) * (xA - xB) + (yA - yB) * (yA - yB) + (zA - zB) * (zA - zB));

Console.WriteLine(result);