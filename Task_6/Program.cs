// Напишите программу которая принимает на вход число и проверяет четное ли оно
// если кратно, то вывести yes, иначе вывести no

Console.Clear();
Console.Write("Enter a number:");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.Write("yes");
else
    Console.Write("no");
