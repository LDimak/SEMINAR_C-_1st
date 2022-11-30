/* Напишите программу которая на входе принимает пятизначное число и проверяет является ли оно палиндромом */

Console.Clear();
// int n5 = Convert.ToInt32(Console.ReadLine());
// int n4 = Convert.ToInt32(Console.ReadLine());
// int n3 = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());
// int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a 5-digit number: 10000~99999");
int n = Convert.ToInt32(Console.ReadLine());

 if (n<10000 || n>100000)  Console.WriteLine("The number is out of tolerance");
 else
     {
      int n5 = n%10;
      Console.WriteLine ($"Fifth digit is {n5}");
      int n4 = ((n - n5)/10)%10;
      Console.WriteLine ($"Fourth digit is {n4}");
      int n3 = ((n - n5 - n4*10)/100)%10;
      Console.WriteLine ($"Third digit is {n3}");
      int n2 = ((n - n5 - n4*10 - n3*100)/1000)%10;
      Console.WriteLine ($"Second digit is {n2}");
      int n1 = ((n - n5 - n4*10 - n3*100 - n2*1000)/10000)%10;
      Console.WriteLine ($"First digit is {n1}");
      if (n1 == n5 && n2 == n4) Console.WriteLine("The number is a palindrom");
      else Console.WriteLine ("The number is not a palindrom");
     }

