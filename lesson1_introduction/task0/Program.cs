// Программа, которая на вход принимает число и выдаёт его квадрат

Console.Write("Введите целочисленное число -> ");
int num = int.Parse(Console.ReadLine());
int result = num * num;
Console.WriteLine("Квадрат вашего числа равен = " + result);
Console.ReadKey();