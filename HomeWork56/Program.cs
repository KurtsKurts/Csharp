/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumRow(int[,] arrayRowSum)
{
    Console.WriteLine();
    int minSumRow = 1000;
    int minArrayI = 0;
    for (int i = 0; i < arrayRowSum.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < arrayRowSum.GetLength(1); j++)
        {
            sumRow = sumRow + arrayRowSum[i, j];
        }
        if (minSumRow > sumRow)
        {
            minSumRow = sumRow;
            minArrayI = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов = {minSumRow}");
    Console.WriteLine();
    Console.WriteLine($"Строка -> {minArrayI}");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);

SumRow(array);