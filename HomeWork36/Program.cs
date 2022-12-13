/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0   */

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

int UnEvenSum(int[] arr)
{
    Console.WriteLine();
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");
    return sum;
}

UnEvenSum(RandomArray(8));
