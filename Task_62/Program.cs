// Задача 62: Заполните спирально массив 4 на 4.

void PrintArray(int[,] array) //вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Enter size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    array[i, j] = num;
    if (i <= j + 1 && i + j < size - 1) // формулирование первой строки матрицы
        j=j+1;
    else if (i < j && i + j >= size - 1) // формулирование перехода на ячейку вниз после обработки первой строки
        i=i+1;
    else if (i >= j && i + j > size - 1) // 
        j=j-1;
    else
        i=i-1;
    num++;
}
PrintArray(array);