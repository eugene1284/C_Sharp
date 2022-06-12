/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
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

double GetLengthVector(double x1, double y1, double x2, double y2)
{
    double difX = Math.Pow((x1 - x2), 2);
    double difY = Math.Pow((y1 - y2), 2);
    double length = Math.Sqrt(difX + difY);
    return length;
}

int x1 = GetNumber("Введите координату X1 точки А: ");
int y1 = GetNumber("Введите координату Y1 точки А: ");
int x2 = GetNumber("Введите координату X2 точки B: ");
int y2 = GetNumber("Введите координату Y2 точки B: ");

double result = GetLengthVector(x1, y1, x2, y2);
Console.WriteLine(result);