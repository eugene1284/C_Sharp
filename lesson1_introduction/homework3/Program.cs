/*Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
Console.Write("Введите число -> ");
double num = double.Parse(Console.ReadLine());
double result = num % 2;

if( result == 0 )
{
 Console.WriteLine("Введённое вами число является чётным");
}
else
{
 Console.WriteLine("Введённое вами число является нечётным");
}