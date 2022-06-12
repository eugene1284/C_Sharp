/*
Напишите программу, которая на вход принимает одно число
(N), а на выходе показывает все целые числа в промежутке от -N
до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/

Console.Write("Введите целочисленное число ");
int numberN = int.Parse(Console.ReadLine());

int negative_number = numberN * (-1);

for (int i = negative_number; i <= numberN; i++)
{
    Console.Write(i + " ");
}