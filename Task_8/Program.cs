// Напишите программу которая принимает на вход число N а на выходе выдает четные  числа в диапазоне [1;n]

Console.Clear();
Console.Write("Enter a number:");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=2)
{
for (int i = 2; i <= n; i=i+2)

    Console.Write($" {i} "); 
}
else
Console.Write("введенное число слишком мало"); 