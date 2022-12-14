/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

double[] RandomArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 50 - rnd.Next(100) + rnd.NextDouble();
        Console.WriteLine(array[i] + " ");
    }
    return array;
}
//RandomArray(5);

double MaxMinDiff(double[] arr)
{
    Console.WriteLine();
    double min = arr[0];
    double max = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
         max = arr[i];
        if (arr[i] < min)
         min = arr[i];
    }
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"Разница между MAX и MIN элементов = {max-min}");
    return max;
    return min;
    Console.WriteLine(min);
}

MaxMinDiff(RandomArray(8));