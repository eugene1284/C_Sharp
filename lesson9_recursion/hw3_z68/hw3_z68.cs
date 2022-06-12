/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
            if (numberInt < 0) System.Console.WriteLine("Введите целое число больше нуля");
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

int AccermanFunction(int m, int n)
{
    var resultA = 0;
    if ((n == 0) && (m == 0)) return resultA = 1;
    if (m == 0) return resultA = n + 1;
    if ((m > 0) && (n == 0)) return resultA = AccermanFunction(m - 1, 1);
    if ((m > 0) && (n > 0)) return resultA = AccermanFunction(m - 1, AccermanFunction(m, n - 1));
    else
    return resultA;
}

int m = NumberInput("m для вычисления функции Аккермана от n и m");
int n = NumberInput("n для вычисления функции Аккермана от n и m");

int resultAccerman = AccermanFunction(m, n);
System.Console.WriteLine($"Значение функции Аккермана: {resultAccerman}");