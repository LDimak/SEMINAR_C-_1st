/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным */

Console.Clear();
Console.WriteLine("Enter a number of a day of the week");
int n = Convert.ToInt32(Console.ReadLine());
if (n>7 || n<1) Console.WriteLine("the number is out of interval 1~7");
else
{
    if (n == 7) Console.WriteLine ("The day is Sunday");
    else Console.WriteLine ("The day is not Sunday");
}
