//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) Console.Write($"max = {a}");
else if (b > a && b > c) Console.Write($"max = {b}");
else if (c > a && c > b) Console.Write($"max = {c}");
else if (a == c || a == b) Console.Write($"max = {a}");
else if (b == c) Console.Write($"max = {b}");
