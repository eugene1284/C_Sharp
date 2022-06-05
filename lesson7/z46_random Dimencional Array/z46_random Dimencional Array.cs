/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
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

int firstDemension = GetDemension("Введите длину для первого разряда матрицы:");
int secondDemension = GetDemension("Введите длину для второго разряда матрицы:");

int [,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);

