/* Напишите программу которая принимает два числа и выдает какое больше и какое меньше */

Console.Clear();
Console.Write("Enter the first number :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number :");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
    Console.WriteLine($" {a}  is greater than {b}");
else if (a<b)
    Console.WriteLine($" {a} is less than {b}");
else
    Console.WriteLine($" {a} is equal {b}");