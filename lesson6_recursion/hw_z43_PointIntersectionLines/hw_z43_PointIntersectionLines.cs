/*
Задача 43. Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
k1 = 5
b1 = 2
k2 = 9
b2 = 4 
-> (-0,5; 5,5) // правильный вариант ответа по такому кейсу (-0.5, -0.5), 
проверить можно тут https://ru.onlinemschool.com/math/assistance/cartesian_coordinate/lines_intersection/
*/

(double, double) CalculatePointIntersection(double k1, double b1, double k2, double b2) // метод, который высчитывает точку пересечения
{
    double x = (((-1) * (b1 - b2)) / (k1 - k2));
    double y = k1 * x + b1;
    return (x, y);
}

double InputNumber(string text)
{
    Console.WriteLine($"Введите {text}");
    double number = double.Parse(Console.ReadLine());
    return number;
}


Console.WriteLine("Данная программа считает точку пересечения прямых y = k1 * x + b1, y = k2 * x + b2");
double k1 = InputNumber("k1");
double b1 = InputNumber("b1");
double k2 = InputNumber("k2");
double b2 = InputNumber("b2");

if (k1 == k2) Console.WriteLine("Линии не пересекаются");
else
{
    (double x, double y) = CalculatePointIntersection(k1, b1, k2, b2);
    Console.WriteLine($"Точка пересечения прямых имеет координинаты: {x},{y}");
}