/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.*/

void InputMatrix(int[,] matrix) // функция заполнения матрицы числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 101); // [0, 100]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void newMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j; //определяем позицию на которую смотрим
            for (int x = j+1; x < array.GetLength(1); x++) //первый элемент не трогаем, начинаем со следующего
                {
                    if(array[i,x] > array[i,maxPosition]) maxPosition = x;
                }
    // делаем замену местами ///////////////////////////////////////////////
        int temporary = array[i,j];
        array[i,j] = array[i,maxPosition];
        array[i,maxPosition] = temporary;
        }
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Enter matrix size: "); // задаем размер матрицы 
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
int[,] SortedMatrix = new int[coord[0], coord[1]];

Console.WriteLine("Initial matrix");
InputMatrix(matrix);
Console.WriteLine("Matrix sorted in descending order");
newMatrix(matrix);
