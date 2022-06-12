/*2. Напишите программу, которая выводит
случайное число из отрезка [10, 99] и показывает
наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8

*/
int number = new Random().Next(10,100);
Console.WriteLine($"Сгенерированное число: {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

Console.WriteLine($"Первое число: {firstDigit}, второе число: {secondDigit}");

int max = firstDigit > secondDigit ? firstDigit : secondDigit;

Console.WriteLine($"Наибольшая цифра из чисел: {max}");

// second variant
//int number = Convert.ToInt32(Math.Pow(2,10));
//Console.WriteLine(number);