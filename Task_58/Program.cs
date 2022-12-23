// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] array) // функция заполнения матрицы числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11); // [0, 10]
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Multiplication(int[,] matrix1, int[,] matrix2, int[,] matrixResult) 
//  
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrixResult[i,j] = matrix1[i, j] * matrix2[i, j]; 
                    Console.Write($"{matrixResult[i, j]} \t");
                }
            Console.WriteLine();
        }
}

Console.Clear();
Console.Write("Enter matrix size: "); // просим размер матрицы 
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // вводим размер матрицы
int[,] matrix1 = new int[coord[0], coord[1]]; // задаем матрицу 1
int[,] matrix2 = new int[coord[0], coord[1]]; // задаем матрицу 2
int[,] matrixResult = new int[coord[0], coord[1]]; // задаем итоговую матрицу 

Console.WriteLine("matrix1");
InputMatrix(matrix1);
Console.WriteLine("matrix2");
InputMatrix(matrix2);
Console.WriteLine("Resulting matrix is beliw:");
Multiplication(matrix1, matrix2, matrixResult);