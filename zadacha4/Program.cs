//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b) max = b;
if (max < c) max = c;
Console.Write($"Максимальное число = {max}");