/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
if ((num < 100) && (num > -100)) Console.WriteLine($"третьей цифры нет");

else {
    if (num > 0) {    
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[1]}");
    }

    else {    
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[2]}");
    }

}