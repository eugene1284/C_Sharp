/*
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

9 2 3
4 2 4
2 6 7
*/


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} ");
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // метод, который заполняет массив случайными числами от 1 до 9
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void DeleteMin(int[,] matr)
{
    int indMinRows = 0;
    int indMinColumns = 0;
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                indMinRows = i;
                indMinColumns = j;
            }
        }
    }

    int[,] shortMatr = new int[matr.GetLength(0) - indMinRows, matr.GetLength(1) - indMinColumns];


    for (int i = 1; i <= matr.GetLength(0) - 1 - indMinRows; i++)
    {
        for (int j = 1; j <= matr.GetLength(1) - 1 - indMinColumns; j++)
        {
            shortMatr[i, j] = matr[indMinRows + i , indMinColumns + j];
            Console.Write($"{shortMatr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
DeleteMin(matrix);