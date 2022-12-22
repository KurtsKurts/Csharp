// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

int[,] GetArray()
{

    int[,] result = new int[4, 4];
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
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


void SearchElement(int[,] arraySearchElem, int a, int b)
{
    Console.WriteLine();
    if (arraySearchElem.GetLength(0) > a && arraySearchElem.GetLength(1) > b) 
    Console.WriteLine (arraySearchElem[a,b]);
    else Console.WriteLine("Такого элемента массива нету");
}


int[,] array = GetArray();
PrintArray(array);

Console.Write("Введите в какой строке искать:  ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите в каком столбце искать: ");
int column = int.Parse(Console.ReadLine()!);


SearchElement(array, row, column);