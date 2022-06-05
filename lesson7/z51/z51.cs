/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int GetDemension(string message)
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int [,] InitMatrix(int firstDemension, int secondDemension)
{
    int [,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for(int i = 0; i < firstDemension; i++)
    {   
        for(int j = 0; j < secondDemension; j++)
        matrix[i, j] = rnd.Next(1,20);
    }

    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    Console.WriteLine("Заполненная матрица");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

int GetSumDiagonal (int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i,j];
        }
    }
    return sum;
}

int firstDemension = GetDemension("Введите длину для первого разряда матрицы:");
int secondDemension = GetDemension("Введите длину для второго разряда матрицы:");

int [,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);
int summDiagonalMatrix = GetSumDiagonal(matrix: resultMatrix);
Console.WriteLine($"Сумма элементов главной диагонали: {summDiagonalMatrix}");