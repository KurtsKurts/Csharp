// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int SumNums(int number)
{
    int sum = 0;
    int num1 = number / 10000000;
    int num2 = number % 10000000 / 1000000;
    int num3 = number % 1000000 / 100000;
    int num4 = number % 100000 / 10000;
    int num5 = number % 10000 / 1000;
    int num6 = number % 1000 / 100;
    int num7 = number % 100 / 10;
    int num8 = number % 10;
    sum = num1 + num2 + num3 + num4 + num5+num6+num7+num8;
    //Console.WriteLine($"{num1}+{num2}+{num3}+{num4}+{num5}+{num6}+{num7}+{num8}");
    return sum;
}


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{SumNums(num)}");