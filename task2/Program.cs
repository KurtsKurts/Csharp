/*Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8*/

int num = new Random().Next(10, 100);

int a1 = num / 10;
int a2 = num % 10;
if (a1 > a2)
{
    Console.WriteLine ($"В числе {num} максимальное {a1}");
}
else if (a1<a2)
{
    Console.WriteLine ($"В числе {num} максимальное {a2}");
}
else
{
    Console.WriteLine($"В числе {num} числа равны");
}