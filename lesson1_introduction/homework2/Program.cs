/*Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите первое число -> ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число -> ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Введите третье число -> ");
double num3 = double.Parse(Console.ReadLine());

if((num1 > num2) & (num1 > num3))
{
 Console.WriteLine("Наибольшее из этих двух чисел: " + num1);
}
else
{
    if(num2 > num3)
    {
    Console.WriteLine("Наибольшее из этих двух чисел: " + num2);
    }
    else
    {
    Console.WriteLine("Наибольшее из этих двух чисел: " + num3);
    }
}

/* реализация #2
Console.Write("Введите первое число -> ");
double num1 = double.Parse(Console.ReadLine());

Console.Write("Введите второе число -> ");
double num2 = double.Parse(Console.ReadLine());

Console.Write("Введите третье число -> ");
double num3 = double.Parse(Console.ReadLine());

double max_number = num1;

if((num2 > num1) & (num2 > num3)) max_number = num2;
if((num3 > num1) & (num3 > num1)) max_number = num3;

Console.WriteLine("Наибольшее из этих двух чисел: " + max_number);
*/