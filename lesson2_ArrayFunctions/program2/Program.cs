/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100,1000);
string strr = number.ToString();

Console.WriteLine($"{number} -> {strr[0]}{strr[2]}");

/*
второй способ
В принципе как первая задача , только делим на 100 число для первого символа и в конце 
Console.WriteLine(Convert.ToString(firstDigit)+Convert.ToString(secondDigit));
*/