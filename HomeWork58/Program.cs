/* Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] GetMatrix(int m, int n)
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


void PrintMatrix(int[,] inArray)
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

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}



Console.Write("Введите количество строк первой матрицы: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetMatrix(rows, columns);
PrintMatrix(array);
Console.WriteLine();

Console.Write("Введите количество строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] array2 = GetMatrix(rows2, columns2);

PrintMatrix(array2);
Console.WriteLine();
PrintMatrix(MultMatrix(array, array2));