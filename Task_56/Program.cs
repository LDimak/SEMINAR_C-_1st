/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.*/

void InputMatrix(int[,] matrix) // функция заполнения матрицы числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11); // [0, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SumsCalc(int[,] matrix, int[] array) //  функция считает суммы элементов строк и заполняет их в одномерный массив 
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum = sum + matrix[i, j]; 
                }
            array[k] = sum;
            Console.WriteLine($"{array[k]}");
            k++;
        }
        Console.WriteLine();
    
}

void MinRowFind(int[] array) // поиск минимального элемента одномерного массива и его позиции
{
    int minRow = array[0];
    int minPos = 0;
    for (int k = 0; k < array.Length-1; k=k+1)
    {
        if (array[k] <= minRow) 
        {
            minRow = array[k];
            minPos = k;
        }
    }
    Console.WriteLine($"minimum row sum is : {minRow}");
    Console.WriteLine($"The number of row with minimum elements summary is: {minPos}");
    
}


Console.Clear();
Console.Write("Enter matrix size: "); // просим размер матрицы 
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // вводим размер матрицы
int[,] matrix = new int[coord[0], coord[1]]; // создаем матрицу
int[] array = new int[coord[0]]; //создаем и задаем одномерный массив


Console.WriteLine("Initial matrix");
InputMatrix(matrix);
Console.WriteLine("Sums are: ");
SumsCalc(matrix,array);
MinRowFind(array);
