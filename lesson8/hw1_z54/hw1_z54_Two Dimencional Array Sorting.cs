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

void FirstLastReplacement(int[,] matr) // метод, который меняет местами первую и последнюю строчку
{
    int[] temp = new int [matr.GetLength(1)];
    var i = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp [j] = matr [i,j];
    }

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr [0,j] = matr [matr.GetLength(0) - 1,j];
        matr [matr.GetLength(0) - 1, j] = temp [j];
    }
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);