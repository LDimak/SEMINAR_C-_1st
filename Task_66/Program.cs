/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму  элементов в промежутке от M до N. */

int rec(int m, int n)
{
    if (m == n)
        return 0;
    return rec(m + 1, n) + m;
    
}
Console.Clear();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));
