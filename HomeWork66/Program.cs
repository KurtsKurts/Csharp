/* Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNaturNumb(int m, int n, int sum = 0)
{
    if (m <= n) sum = m + SumNaturNumb(m + 1, n);
    return sum;
}

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write(SumNaturNumb(M, N));