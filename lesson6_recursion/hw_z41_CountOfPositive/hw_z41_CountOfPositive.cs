/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int CountOfPositive(string[] array) // метод, который считает количество введённых чисел больше нуля
{
    int countOfPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.TryParse(array[i], out int number) && number > 0)
            countOfPositive++;
    }

    return countOfPositive;
}


Console.WriteLine("Введите числа через запятую:");
string strNumber = Console.ReadLine();
string[] array = strNumber.Split(",");

Console.WriteLine($"Количество чисел больше 0{CountOfPositive(array)}");