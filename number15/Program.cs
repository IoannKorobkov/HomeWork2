// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Как я понял 6 и 7 дни - это выходные
Console.WriteLine("Введите цифру дня недели");
int n = int.Parse(Console.ReadLine());

if(n == 1)
{
    Console.WriteLine("--> нет");
}
if(n == 2)
{
    Console.WriteLine("--> нет");
}
if(n == 3)
{
    Console.WriteLine("--> нет");
}
if(n == 4)
{
    Console.WriteLine("--> нет");
}
if(n == 5)
{
    Console.WriteLine("--> нет");
}
if(n == 6)
{
    Console.WriteLine("--> да");
}
if(n == 7)
{
    Console.WriteLine("--> да");
}