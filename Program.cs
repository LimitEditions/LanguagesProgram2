// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int num1, num2, num3, num4, num5;

// num5 = num%10;
// num4 = num/10%10;
// num3 = num/100%10;
// num2 = num/1000%10;
// num1 = num/10000%10;

// if (num1 == num5 && num2 == num4)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

// System.Console.WriteLine(num1+" "+num2+" "+num3+" "+num4+" "+num5);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double result = (Math.Pow(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2),0.5));
// // double result = (Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)));
// result = Math.Round(result,2);

// Console.WriteLine(result);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Hello, World!");

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int i;
// for (i = 1; i <= num; i++)
// {
//     Console.Write(Math.Pow(i,3)+" ");
// }
