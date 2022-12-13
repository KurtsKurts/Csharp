// Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] NewArray(int size)
{
int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = new Random().Next(0, 100);
        // Console.Write(array[i] + " ");
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for( int i=0; i<array.Length-1;i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write("]");
}
PrintArray(NewArray(8));