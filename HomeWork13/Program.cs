/*Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/


Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine());
int num = numberA/100;
if( num == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (num > 0)
{
    Console.WriteLine(num%10);
}
else
{
    Console.WriteLine(num%10*-1);
}