/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
int[,,] FillRandomArray(int axis0, int axis1, int axis2) // метод, который заполняет массив случайными неповторяющимися двузначными числами
{
    Random rnd = new Random();
    int[,,] array = new int[axis0, axis1, axis2];
    for (int i = 0; i < axis0; i++)
        for (int j = 0; j < axis1; j++)
            for (int k = 0; k < axis2; k++)
            {
                bool uniqueNumber = true;
                while (uniqueNumber)
                {
                    array[i, j, k] = rnd.Next(10, 100);
                    uniqueNumber = FindNumberInArray(array[i, j, k], array);
                }
            }
    return array;
}

void PrintArrayLine(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.WriteLine($"{i}.{j}.{k}.\t{array[i, j, k]}");
}

bool FindNumberInArray(int number, int[,,] array) // метод, который принимает на вход случайное число и отдаёт ложь, если такое число уже есть в массиве array
{
    bool result = true;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (number == array[i, j, k]) result = false;
    return result;
}

Console.WriteLine("Введите размерность массива 0");
int axis0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размерность массива 1");
int axis1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размерность массива 2");
int axis2 = int.Parse(Console.ReadLine());

int[,,] array = FillRandomArray(axis0, axis1, axis2);
PrintArrayLine(array);