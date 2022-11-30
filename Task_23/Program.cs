/* Напишите программу которая на входе принимает число n , а на выходе выдает таблицу кубов от 1 до n */

Console.Clear();
Console.WriteLine ("Enter a number ");
int n = Convert.ToInt32(Console.ReadLine());
int x = 1;
Console.WriteLine();
while (x!=n+1)
{
    Console.WriteLine(Math.Pow(x,3));
    x = x + 1;
}
