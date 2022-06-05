/*Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4

A22
A24
A42
A44
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

void ArrayPow (int [,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j = j + 2)
        matrix [i,j] *= matrix [i,j];
    }
}

int firstDemension = GetDemension("Введите длину для первого разряда матрицы:");
int secondDemension = GetDemension("Введите длину для второго разряда матрицы:");

int [,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);
ArrayPow(matrix: resultMatrix);
PrintMatrix(matrix: resultMatrix);