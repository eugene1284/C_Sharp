/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

void PrintArray(int[,] matr) // метод, который печатает массив
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // метод, который заполняет массив случайными числами от 1 до 9
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // [1,10)
        }
    }
}

void SortingRowsArray(int[,] matr)
{
    var temp = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int max = matr[i, 0];
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j + 1; k < matr.GetLength(1); k++)
                if (matr[i, j] > matr[i,k])
                {
                    temp = matr[i, k];
                    matr[i,k] = matr[i,j];
                    matr[i,j] = temp;
                }

        }

    }
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
SortingRowsArray(matrix);
PrintArray(matrix);