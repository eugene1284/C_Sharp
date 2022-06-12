/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());
if ((num < 100) && (num > -100)) Console.WriteLine($"третьей цифры нет");

else {
    if (num > 0) {    
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[2]}");
    }

    else {    
    string str = num.ToString();
    Console.WriteLine($"{num} -> {str[3]}");
    }

}