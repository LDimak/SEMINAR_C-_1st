/* Напишите программу, которая принимает на вход координаты двух точек и выводит расстояние между ними в 3D*/

Console.Clear();
Console.WriteLine ("Enter coordinate X1");
double x1 = Convert.ToDouble(Console.ReadLine()); // дробное число
Console.WriteLine ("Enter coordinate Y1");
double y1 = Convert.ToDouble(Console.ReadLine()); // дробное число
Console.WriteLine ("Enter coordinate Z1");
double z1 = Convert.ToDouble(Console.ReadLine()); // дробное число
Console.WriteLine ("Enter coordinate X2");
double x2 = Convert.ToDouble(Console.ReadLine()); // дробное число
Console.WriteLine ("Enter coordinate Y2");
double y2 = Convert.ToDouble(Console.ReadLine()); // дробное число
Console.WriteLine ("Enter coordinate Z2");
double z2 = Convert.ToDouble(Console.ReadLine()); // дробное число

double s = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
Console.WriteLine (s);
