/* Задайте двумерный массив.
Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2      */


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

void NewMaxMinArray(int[,] arrayWork)
{
    for (int i = 0; i < arrayWork.GetLength(0); i++)
    {

        for (int j = 0; j < arrayWork.GetLength(1); j++)
        {
            int max = j;
            for (int k = j + 1; k < arrayWork.GetLength(1); k++)
            {
                if (arrayWork[i, k] > arrayWork[i, max]) max = k;
            }
            int buff = arrayWork[i, j];
            arrayWork[i, j] = arrayWork[i, max];
            arrayWork[i, max] = buff;


        }
    }
}



Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);

Console.WriteLine();
NewMaxMinArray(array);
PrintArray(array);