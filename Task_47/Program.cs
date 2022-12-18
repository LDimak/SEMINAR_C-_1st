/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами */

void InputMyMassive(double[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = Math.Round(new Random().NextDouble() * (50 - 10) + 10, 2);  // [-50, 50]
            Console.Write($"{table[i, j]} \t");
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Enter qty rows and columns separated with space: ");
/* ниже принимается строка, создает массив где каждый элемент строчный. С помощью функции .Select
проходим по каждому элементу строкового массива. Затем с помощью функции Parse делаем этот элемент числом
и с помощью функции ToArray выводим эти элементы уже в виде числового массива */ 
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray(); 
double[,] table = new double[coord[0],coord[1]];
InputMyMassive(table);