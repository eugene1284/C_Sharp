/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
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

void PrintNumbersRecursion (int min, int max)
{
    System.Console.Write($"{min++}, ");
    if (min <= max)
        PrintNumbersRecursion(min,max);
}

int min = NumberInput("значение Min");
int max = NumberInput("значение Max");
System.Console.WriteLine();
PrintNumbersRecursion(min,max);