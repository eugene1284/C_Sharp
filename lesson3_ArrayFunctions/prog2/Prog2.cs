// shift Alt F - для красивого форматирования!!!!!!!!!!!!

/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/


string GetQuarter(int Quarter) // функция, которая получает четверть
{
    if (Quarter == 1) return "Диапазон значений для данной четверти x > 0, y > 0";
    else if (Quarter == 4) return "Диапазон значений для данной четверти x > 0, y < 0";
    else if (Quarter == 3) return "Диапазон значений для данной четверти x < 0, y < 0";
    else if (Quarter == 2) return "Диапазон значений для данной четверти x < 0, y > 0";
    else
        return "0";
}


// функция, которая получает число, введённое с клавиатуры
// + проверка на то, что ввели именно число
// + проверка число =! 0
int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number)) //из valueFromConsole преобразуем в строку //каст - преобразование
        {
            if (number == 1 || number == 2 || number == 3 || number == 4)
                return number;
            else
            {
                Console.WriteLine("Такой четверти не существует");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }

    return 0;
}

string messageQuarter = "Введите номер четверти из декартовой системы координат: ";
int Quarter = GetNumber(messageQuarter);
string diapazon = GetQuarter(Quarter);
Console.WriteLine(diapazon);