/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int NumberInput(string text) // метод введения числа и проверки ввода
{
    bool isInputInt = true;
    int number = 0;
    while (isInputInt)
    {
        System.Console.WriteLine($"Введите {text} :");
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out int numberInt))
        {
            if (numberInt <= 0) 
            {
                number = Math.Abs(numberInt);
                isInputInt = false;
            }
            else
            {
                number = numberInt;
                isInputInt = false;
            }

        }
        else
            Console.WriteLine("введите число");

    }
    return number;
}

int SummRecursion(int min, int max) // метод, который находит сумму рекурсивно
{
    if (min > max) return 0;
    else return min + SummRecursion(min+1,max);
}

int min = NumberInput("значение Min");
int max = NumberInput("значение Max");
Console.WriteLine($"рекурсия. суммирование от 1 до n: {SummRecursion(min, max)}");