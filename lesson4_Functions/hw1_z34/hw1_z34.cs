/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int [] InitArray(int length) //метод, который инициализирует массив из length элементов в определённом промежутке
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(99, 1000); // [a,b)
}

return arr;
}

void PrintArray(int [] arr) //метод, который печатает наш массив на консоль
{
foreach(int item in arr)
Console.Write($"{item} ");
}

int EvenCount(int [] arr) // метод, который производит проверку элемента заданного массива на чётность
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
        count++;
        }
    }
    return count;
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.Write("Массив: ");
PrintArray(arr);

Console.WriteLine("");

Console.Write("Количество чётных чисел в вышеуказанном массиве: ");
int count = EvenCount(arr);
Console.WriteLine(count);