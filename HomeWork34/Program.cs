/*Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] BigArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

int EvenNum (int[] arr)
{
    Console.WriteLine();
    int pos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        pos++;
    }
    Console.WriteLine($"Количество четных числе в массиве -> {pos}");
    return pos;

}


EvenNum(BigArray(8));
