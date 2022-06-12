/*Задача 19: Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

void checkPalindrom (string numberToString)
{
    if ((numberToString[0] == numberToString[4]) && (numberToString[1] == numberToString[3])) 
    {
        Console.WriteLine("Введённое вами число является палиндромом");
    }
    else 
    {
        Console.WriteLine("Введённое вами число не является палиндромом");
    }
}

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();
        

        if (int.TryParse(valueFromConsole, out int number))
        {       
            if ((number >= 10000) && (number < 100000)) 
                return number;
            else
            {
                Console.WriteLine("Некорректный ввод. Введите 5 значное положительное число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
        
    }
}

string message = "Введите 5-значное число ";
int number = GetNumber(message);
string numberToString = number.ToString();
checkPalindrom(numberToString);