/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void MinElementsRowsSumm(int[,] matrix)
{
    int[] sumElementsRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            sumElementsRows[i] += matrix[i, j];
    int min = sumElementsRows[0];
    int minSumElementsRow = 0;
    for (int i = 0; i < sumElementsRows.Length; i++)
        if (sumElementsRows[i] < min)
        {
            min = sumElementsRows[i];
            minSumElementsRow = i;
        }
    Console.WriteLine($"В строке {minSumElementsRow + 1} наименьшая сумма элементов");
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinElementsRowsSumm(matrix);