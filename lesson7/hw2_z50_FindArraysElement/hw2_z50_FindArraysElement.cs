/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void FindArraysElement(int[,] matr)
{
    Console.WriteLine("Введите строку искомого элемента массива");
    int row = Convert.ToInt32(Console.ReadLine());
    if (row > matr.GetLength(0)) Console.WriteLine("Такой строки в массиве нет");

    Console.WriteLine("Введите столбец искомого элемента массива");
    int column = Convert.ToInt32(Console.ReadLine());
    if (column > matr.GetLength(1)) Console.WriteLine("Такого столбца в массиве нет");
    Console.WriteLine($"Искомый элемент массива равен: {matr[row - 1, column - 1]}");
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
FindArraysElement(matrix);