/*
Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа: ");
int b = int.Parse(Console.ReadLine());

int result = PowResult(a,b);
Console.WriteLine(result);

int PowResult (int a, int b)
{
    if (b == 1) return a;
    b--;
    return a * PowResult(a,b);
}