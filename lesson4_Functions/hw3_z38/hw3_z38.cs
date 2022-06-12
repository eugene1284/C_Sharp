/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int [] InitArray(int length) //метод, который инициализирует массив из length элементов в определённом промежутке
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(0,10); // [a,b)
}

return arr;
}

void PrintArray(int [] arr) //метод, который печатает наш массив на консоль
{
foreach(int item in arr)
Console.Write($"{item} ");
}


int DiffMinMax(int [] arr) //метод, находит макс и мин и считает разницу между ними
{
    int min = arr[0];
    int max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
       if (arr[i] < min) min = arr[i];
       if (arr[i] > max) max = arr[i];
    }

    int diffMinMax = max - min;
    return diffMinMax;

}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.Write("Массив: ");
PrintArray(arr);

Console.WriteLine("");

Console.Write("Разница между максимальным и минимальным элементов массива: ");
Console.WriteLine(DiffMinMax(arr));