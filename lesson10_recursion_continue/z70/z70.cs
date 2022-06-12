/*
Задача 70: Напишите программу, которая на вход принимает два числа 
и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int result))
            return result;
    }
    Console.WriteLine("ошибка");
}

void Progressive(int first, int second, int count)
{
    int i = 0;
    if (i < count)
    {
        Console.Write($"{first} ");
        Progressive(second, first + second, count - 1);
    }
}

int firstNumber = GetNumber("Введите первое число");
int secondNumber = GetNumber("Введите второе число");
int countNumber = GetNumber("Введите число N");
Progressive(firstNumber, secondNumber, countNumber);