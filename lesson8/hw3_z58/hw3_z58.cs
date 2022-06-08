/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

void MultiplicationArrays(int[,] matrix1, int[,] matrix2)
{
    int rowMatrix1 = matrix1.GetLength(0);
    int columnMatrix1 = matrix1.GetLength(1);
    int rowMatrix2 = matrix2.GetLength(0);
    int columnMatrix2 = matrix2.GetLength(1);
    int[,] productArray = new int[rowMatrix1, columnMatrix1];
    for (int i = 0; i < rowMatrix1; i++)
        for (int j = 0; j < columnMatrix2; j++)
            for (int k = 0; k < columnMatrix1; k++)
                productArray[i, j] += matrix1[i, k] * matrix2[k, j];
                Console.WriteLine("Произведение вышеуказанных матриц:");
    PrintArray(productArray);
}



int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();
MultiplicationArrays(matrix1, matrix2);
