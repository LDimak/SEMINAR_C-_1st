// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
Console.WriteLine("Enter 1st number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number");
int b = Convert.ToInt32(Console.ReadLine());
int mult = a;
int grade = 1;
while (grade < b)
{
    mult = mult * a;
    grade = grade + 1;
}
Console.WriteLine(mult);
