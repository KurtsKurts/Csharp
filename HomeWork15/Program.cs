/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет,
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Введите день недели цифрой: ");
int day = int.Parse(Console.ReadLine());

if (day == 6 | day == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}