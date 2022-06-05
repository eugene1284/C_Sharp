/*
Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int[,] RandomArrayCreation(int rows , int colums , int minRandom , int maxRandom)//вставил на всякий случай возможность изменения рандомности чисел
{
    Random rnd = new Random();
    int[,] array = new int[rows,colums];
    for ( int i = 0 ; i < rows ; i ++)
        for ( int j = 0 ; j < colums ; j ++)
            array[i,j] = rnd.Next(minRandom,maxRandom+1);
return array;
}

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

void ArrayPrint(int[,] array)
{
    Console.Write("\n");
    for ( int i = 0 ; i < array.GetLength(0) ; i ++)
    {
        Console.Write($"Строка {i+1}");
        for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            Console.Write($"\t{array[i,j],3}"); 
        Console.Write("\n");
    }
}

int[,] LaneColumsChangeInArray(int[,] array)
{
    int[,] arrayNew = new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0 ; i < array.GetLength(0); i++ )
        for (int j = 0 ; j < array.GetLength(1) ; j++)
            arrayNew[j,i] = array[i,j];
    return arrayNew;
}

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");
/*if (rows != colums) Console.Write("Не возможно поменять местами строки столбцы");
else
{*/
    int[,] array= RandomArrayCreation( rows:rows,
                                    colums:colums,
                                    minRandom:0,
                                    maxRandom:9);
    Console.Write("\n Изначальный массив:");
    ArrayPrint(array);
    int[,] arrayNew = LaneColumsChangeInArray(array);
    Console.Write("\n Новый массив:");
    ArrayPrint(arrayNew);
/*}*/
