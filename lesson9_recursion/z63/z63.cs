/*
Задача 63: Задайте значение N. 
Напишите программу, которая 
выведет все натуральные числа
 в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void Natural (int num, int first)
{
    System.Console.Write($"{first++}, ");
    if (first <= num)
        Natural(num, first);
}

int number = int.Parse(System.Console.ReadLine());
int first = 1;
string line = string.Empty;
Natural(number,first);