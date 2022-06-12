/*Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());

double quotient;
quotient = num1 % num2;

if (quotient == 0) 
    Console.WriteLine("Второе число является кратным первому");
else 
    //Console.WriteLine("Второе число не является кратным первому, остаток " + quotient);
    Console.WriteLine($"Второе число не является кратным первому, остаток {quotient}");