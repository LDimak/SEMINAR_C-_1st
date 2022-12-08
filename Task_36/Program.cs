// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// первым делом создаем процедуру для заполнения массива
void InputYourMassive(int[] shit) //внутрь процедуры будем передавать сам наш массив
{
    for (int i=0; i<shit.Length; i++) //проходимся по очереди по элементам массива
    shit[i] = new Random().Next(1,101); 
}

// заведем процедуру по обращению с элементами массива
void ProcessYourMassive(int[] shit)
{
    int sum = 0;
    for (int i=1; i<shit.Length; i=i+2)
    {
        sum = sum + shit[i];
    }
    Console.WriteLine($"Sum of elements of non-even index is {sum}");
}

Console.Clear();
Console.WriteLine("How many elements are in your shitty massive?");
int n = Convert.ToInt32(Console.ReadLine());
int[] shit = new int[n]; //анонсируем что в массиве будет n элементов

// теперь мы можем вызвать процедуру заполнения массива
InputYourMassive(shit);
Console.WriteLine($"[{string.Join(", ", shit)}]");
ProcessYourMassive(shit);
