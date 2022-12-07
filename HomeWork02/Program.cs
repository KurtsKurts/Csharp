// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberC = int.Parse(Console.ReadLine());

if(numberA > numberB & numberA > numberC)
{
    Console.WriteLine("Получается " + numberA);
}
if(numberB > numberC & numberB > numberA)
{
    Console.WriteLine("Получается " + numberB);
}
if(numberC > numberB & numberC > numberA)
{
    Console.WriteLine("Получается " + numberC);
}
else
{
    Console.WriteLine("Не получилось, поменяйте числа;)");
}