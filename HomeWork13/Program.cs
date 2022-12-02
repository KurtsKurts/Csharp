/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());

if (numberA < 0)
{
    numberA = (numberA * (-1));
}

if (numberA < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (numberA < 1000)
{
    Console.WriteLine(numberA % 10);
}
else if (numberA < 10000)
{
    Console.WriteLine(numberA % 100 / 10);
}
else if (numberA < 100000)
{
    Console.WriteLine(numberA % 1000 / 100);
}
else if (numberA < 1000000)
{
    Console.WriteLine(numberA % 10000 / 1000);
}
else if (numberA < 10000000)
{
    Console.WriteLine(numberA % 100000 / 10000);
}
else if (numberA < 100000000)
{
    Console.WriteLine(numberA % 1000000 / 100000);
}
else if (numberA < 1000000000)
{
    Console.WriteLine(numberA % 10000000 / 1000000);
}
else if (numberA < 10000000000)
{
    Console.WriteLine(numberA % 100000000 / 10000000);
}