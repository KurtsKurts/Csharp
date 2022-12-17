/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Write("Введите числа через 'Space'' : ");
int[] Num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

void PosNum(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
            count++;
    }
    Console.WriteLine(count);
}
Console.Write($"Количество положительных чисел -> ");
PosNum(Num);