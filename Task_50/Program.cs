/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет */

void InputMatrix(int[,] table) // заполняем массив случайными числами
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(-10,11);  // [-10, 10]
            Console.Write($"{table[i, j]} \t");
        }
    Console.WriteLine();
    }
}

void FindElement(int[,] table)
{
    Console.Write("Enter row and column of the element you look for: ");
    int[] pos = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray(); 
    if (pos[0] < table.GetLength(0) && pos[1] < table.GetLength(1)) 
    {
       Console.WriteLine($"{table[pos[0], pos[1]]}");
    }
    else Console.WriteLine("Such element doesnt exist");
}

Console.Clear();
Console.Write("Enter size of table: ");
/* ниже принимается строка, создает массив где каждый элемент строчный. С помощью функции .Select
проходим по каждому элементу строкового массива. Затем с помощью функции Parse делаем этот элемент числом
и с помощью функции ToArray выводим эти элементы уже в виде числового массива */ 
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray(); 
int[,] table = new int[coord[0], coord[1]];
InputMatrix(table);
FindElement(table);

