//  Напишите программу, которая задаёт массив из 8 элементов, 
// запрашивает данные(элементы массива) у пользователя и выводит их на экран.

Console.Clear();
int[] shit = new int[8];
for (int i = 0 ; i < shit.Length ; i++)
{
    Console.Write($"Enter {i+1} element of massive: ");
    shit[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", shit)}]"); 