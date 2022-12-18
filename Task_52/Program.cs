// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
 
void InputMatrix(int[,] table) // заполняем массив случайными числами
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] = new Random().Next(0,11);  // [0, 10]
            Console.Write($"{table[i, j]} \t");
        }
    Console.WriteLine();
    }
}

void ProcessColumns(int[,] table)
{
    Console.WriteLine("We are going to calculate column averages now");
    double[,] averages = new double[1,table.GetLength(1)];
    for (int j = 0; j < table.GetLength(1); j++)
    {
        double ColumnTotal = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                ColumnTotal = ColumnTotal + table[i,j];
            }
        averages[0,j] = Math.Round(ColumnTotal/(table.GetLength(0)),2);
        Console.Write($"{averages[0, j]} \t");
    }
    
}

Console.Clear();
Console.Write("Enter size of table: ");
/* ниже принимается строка, создает массив где каждый элемент строчный. С помощью функции .Select
проходим по каждому элементу строкового массива. Затем с помощью функции Parse делаем этот элемент числом
и с помощью функции ToArray выводим эти элементы уже в виде числового массива */ 
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray(); 
int[,] table = new int[coord[0], coord[1]];
InputMatrix(table);
Console.WriteLine();
ProcessColumns(table);

