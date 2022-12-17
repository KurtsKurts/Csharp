/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

k1*x+b1=k2*x+b2
k1*x=k2*x+(b2-b1)
(k1-k2)x=(b1-b2)
x=(b1-b2)/-(k1-k2)

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите значение b1 : ");
float B1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k1 : ");
float K1 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2 : ");
float B2 = float.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2 : ");
float K2 = float.Parse(Console.ReadLine()!);
Console.WriteLine();

void Dot(float b1, float k1, float b2, float k2)
{
    float x;
    float y;
    x = (b1 - b2) / -(k1 - k2);
    y = k2 * x + b2;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");

}

Dot(B1, K1, B2, K2);