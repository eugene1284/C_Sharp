/*Задача 40: Напишите программу, которая принимает на вход три числа
 и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника 
меньше суммы двух других сторон
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int intNumber = int.Parse(Console.ReadLine());
    return intNumber;
}

void Theory_Triangle(int lineA, int lineB, int lineC)
{
    
    if ((lineA < (lineB + lineC)) && (lineB < (lineA + lineC))  && (lineC < (lineA + lineC)))
    Console.WriteLine("Треугольник с такими сторонами может существовать");
    else Console.WriteLine("Треугольник с такими сторонами не может существовать");
}

int lineA = GetNumber("Введите число ");
int lineB = GetNumber("Введите число ");
int lineC = GetNumber("Введите число ");
Theory_Triangle(lineA,lineB,lineC);