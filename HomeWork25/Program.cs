// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Stepen_A_v_B(int a, int b)
{
    int step = 1;
    int pow = 1;
    while (b >= step)
    {
        // Console.Write($" {pow} " );
        pow = pow * a;
        step++;
    }
    return pow;

}


Console.Write("Введите число A : ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B : ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{Stepen_A_v_B(a, b)}");