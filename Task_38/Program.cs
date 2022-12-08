// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// первым делом создаем процедуру для заполнения массива
void InputYourMassive(double[] shit) //внутрь процедуры будем передавать сам наш массив
{
    for (int i=0; i<shit.Length; i++) //проходимся по очереди по элементам массива
    shit[i] = new Random().Next(0,101); 
}

// заведем процедуру по обращению с элементами массива
void ProcessYourMassive(double[] shit)
{
    double max = shit[0];
    double min = shit[0];
    for (int i=0; i<shit.Length; i=i+1)
    {
        if (shit[i]>max) max = shit[i];
        if (shit[i]<min) min = shit[i];
    }
    Console.WriteLine($"Difference between max and min is {max-min}");
}

Console.Clear();
Console.WriteLine("How many elements are in your shitty massive?");
int n = Convert.ToInt32(Console.ReadLine());
double[] shit = new double[n]; //анонсируем что в массиве будет n элементов

// теперь мы можем вызвать процедуру заполнения массива
InputYourMassive(shit);
Console.WriteLine($"[{string.Join(", ", shit)}]");
ProcessYourMassive(shit);
