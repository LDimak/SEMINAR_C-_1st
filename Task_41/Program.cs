// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Enter qty of elements in your massive");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] massive = new int[n]; //объявляем создание начального массива
for (int i=0; i<n ; i++) //заполняем массив случайными числами от -11 до 11
    {
        massive[i] = new Random().Next(-11,12);
        if (massive[i]>0) count=count+1;
    }
Console.WriteLine($"[{string.Join(", ", massive)}]");
Console.WriteLine(count);  

