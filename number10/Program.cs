// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Введите любое число");
int n = int.Parse(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (n >= 1000)
    {
        n = n / 10;
    }
    Console.WriteLine($"{n}");

    int a1 = n % 10;
    Console.WriteLine($"{a1}");
}