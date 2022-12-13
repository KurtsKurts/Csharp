/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

int[] RandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(array[i] + " ");
    }
    return array;
}
// RandomArray(8);

int MaxMinDiff(int[] arr)
{
    Console.WriteLine();
    int min = arr[0];
    int max = arr[0];
    
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