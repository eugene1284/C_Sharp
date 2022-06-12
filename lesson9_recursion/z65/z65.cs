/*
Задача 65: Задайте значения M и N. 
Напишите программу, которая 
выведет все натуральные числа 
в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number =0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
            else
            {
                number = numberInt;
                isInputInt = false;
            } 
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

void PrintNumbers(int numberN,int numberM)
{
    if (numberN != numberM)
    {
        PrintNumbers(numberN-1,numberM);
        Console.Write($" {numberN} ");
    }
    else  Console.Write($"{numberN}");
}

int numberN = NumberInput("числоN");
int numberM = NumberInput("числоM");

PrintNumbers(numberN,numberM);