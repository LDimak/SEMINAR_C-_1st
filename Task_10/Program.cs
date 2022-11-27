// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Enter three-digit number");
int n = Convert.ToInt32(Console.ReadLine());
if (n>=100 && n<=999)
{
Console.WriteLine($"The three-digit number  is: {n}");
}
else Console.WriteLine("The number entered is not a three-digit");

int n2 = (n%100 - n%10)/10;
Console.WriteLine ($"The second digit of the number is: {n2}");
