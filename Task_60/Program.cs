// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void InputMatrixThreeDimensions(int[ , , ] array) // функция заполнения 3-х мерной матрицы числами
{
    int i = 0; int j = 0; int k = 0; int temp = 0;
    
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            for (k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k]= temp++;

                Console.WriteLine($"{array[i,j,k]}  [{i},{j},{k}]");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Enter matrix size, it should be 3 numbers divided by space: "); // просим размер матрицы 
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // вводим размер матрицы
int[ , , ] matrix = new int[coord[0], coord[1], coord[2]]; // задаем матрицу


Console.WriteLine("Matrix is represented below by rows");
InputMatrixThreeDimensions(matrix);

