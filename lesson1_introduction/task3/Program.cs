
/*программа 2
2. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Write("Введите целочисленное число от 1 до 7 -> ");
string dayWeek = Console.ReadLine();
if(dayWeek == "1") Console.WriteLine("Данному числу соответствует Понедельник");
else if (dayWeek == "2") Console.WriteLine("Вторник");
else if (dayWeek == "3") Console.WriteLine("Среда");
else if (dayWeek == "4") Console.WriteLine("Четверг");
else if (dayWeek == "5") Console.WriteLine("Пятница");
else if (dayWeek == "6") Console.WriteLine("Суббота");
else if (dayWeek == "7") Console.WriteLine("Воскресенье");
else Console.WriteLine("Ошибка ввода!");

//встроенная структура DataTime

/*///////////switch (выражение)
/*
    case 1:
        Console.Write("Понедельник");
        break;
    case 2:
        Console.Write("Вторник");
        break;
    //.............
    case значениеN:
        код, выполняемый если выражение имеет значениеN
        break;
    default:
        код, выполняемый если выражение не имеет ни одно из выше указанных значений
        break;

/*if(num == 1)
{
 Console.Write("Понедельник");
}
else
{
    if(num == 2)
    {
    Console.Write("Понедельник");
    }
}*/