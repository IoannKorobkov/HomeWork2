// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Введите любое трехзначное число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n);
int a1 = n % 10;

if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
        Console.WriteLine(a1);
}