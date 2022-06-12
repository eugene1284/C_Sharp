/*
Задача 67: Напишите программу, которая 
будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

int NumbersSumm(int num, int sum)
{
    if (num < 10)
        return sum + num;
    
        int count = num % 10;
        num = num/10;
        sum += count;
        return NumbersSumm(num,sum);
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
var sum = 0;
int numbersSumm = NumbersSumm(num, sum);
Console.WriteLine(numbersSumm);