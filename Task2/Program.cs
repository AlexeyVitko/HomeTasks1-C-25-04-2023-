// // Задача 2: Напишите программу, которая 

// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число a");
int nunber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int nunber2 = Convert.ToInt32(Console.ReadLine());
if (nunber1>nunber2)
{
 Console.WriteLine("Число a есть максимальное");   
}
else
{
 Console.WriteLine("Число b есть максимальное");     
}