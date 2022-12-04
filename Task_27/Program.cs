// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Clear();
Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int LastDigit = 0;
while (n>0)
{
    LastDigit = n%10;
    sum = sum + LastDigit;
    n = n/10;
}
Console.WriteLine($"sum of digits is: {sum}");
