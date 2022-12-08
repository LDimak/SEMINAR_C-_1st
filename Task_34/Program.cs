//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// первым делом создаем процедуру для заполнения массива
void InputYourMassive(int[] shit) //внутрь процедуры будем передавать сам наш массив
{
    for (int i=0; i<shit.Length; i++) //проходимся по очереди по элементам массива
    shit[i] = new Random().Next(1,101); 
}

// заведем функцию по обращению с элементами массива
void ProcessYourMassive(int[] shit)
{
    int count = 0;
    int[] newShit = new int[shit.Length/2 + shit.Length%2];// количество элементов или в 2 раза меньше или в 2 +1
    for (int i=0; i<shit.Length; i++)
    {
        if (shit[i]%2==0) count = count + 1;
    }
    Console.WriteLine($"Qty of even numbers is {count}");
}

Console.Clear();
Console.WriteLine("How many elements are in your shitty massive?");
int n = Convert.ToInt32(Console.ReadLine());
int[] shit = new int[n]; //анонсируем что в массиве будет n элементов

// теперь мы можем вызвать процедуру заполнения массива
InputYourMassive(shit);
Console.WriteLine($"[{string.Join(", ", shit)}]");
ProcessYourMassive(shit);
