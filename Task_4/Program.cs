/* Напишите программу которая принимает три числа и выдает  большее */

Console.Clear();
Console.Write("Enter the first number :");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number :");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number :");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a>max)
    {
    max = b;
    Console.WriteLine($" {b}  is maximum");    
    }
if (c>max)
    {
    max = c;   
    Console.WriteLine($" {c}  is maximum"); 
    }
  
else 
    Console.WriteLine($" {a} is maximum");