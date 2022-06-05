/*
Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
9 6 1 4  m00 m01 m02 m03
7 5 9 2
6 2 7 4  m20 m21 m22 m23

2 = matr.GetLength

6 2 7 4
7 5 9 2
9 6 1 4

matr.GetLength(0) - строки 
matr.GetLength(1) - столбцы

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
Console.WriteLine();
FirstLastReplacement(matrix);
PrintArray(matrix);
