/*
Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число -> ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число -> ");
double num2 = double.Parse(Console.ReadLine());

if(num1 > num2)
{
 Console.WriteLine("Наибольшее из этих двух чисел: " + num1 + ", наименьшее: " + num2);
}
else
{
 Console.WriteLine("Наибольшее из этих двух чисел: " + num2 + ", наименьшее: " + num1);
}


