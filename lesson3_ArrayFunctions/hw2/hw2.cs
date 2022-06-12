/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

*/

int GetNumber(string msg) // функция, которая делает проверку на дурака
{
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if(int.TryParse(valueFromConsole, out int number)) //из valueFromConsole преобразуем в строку //каст - преобразование
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }

    return 0;
}

double GetLengthVector(double x1, double y1, double z1, double x2, double y2, double z2)  // функция, которая считает расстояние между двумя точками по формуле AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
{
    double difX = Math.Pow((x1 - x2), 2);
    double difY = Math.Pow((y1 - y2), 2);
    double difZ = Math.Pow((z1 - z2), 2);
    double length = Math.Sqrt(difX + difY + difZ);
    return length;
}

int x1 = GetNumber("Введите координату X1 точки А: ");
int y1 = GetNumber("Введите координату Y1 точки А: ");
int z1 = GetNumber("Введите координату Z1 точки А: ");
int x2 = GetNumber("Введите координату X2 точки B: ");
int y2 = GetNumber("Введите координату Y2 точки B: ");
int z2 = GetNumber("Введите координату Z2 точки B: ");

double result = GetLengthVector(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);