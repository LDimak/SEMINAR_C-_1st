// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int x = 0;
if (n<100) Console.WriteLine("There is no third digit, please enter a larger number");
else
{
while (n>=100)
{
x = n%10; //finding the last digit
n = (n-x)/10; //removing the last digit
}
Console.WriteLine($"the third digit is {x}");
}
