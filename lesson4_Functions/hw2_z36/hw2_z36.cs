/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] InitArray(int length) //метод, который инициализирует массив из length элементов в определённом промежутке
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-100, 100); // [a,b)
}

return arr;
}

void PrintArray(int [] arr) //метод, который печатает наш массив на консоль
{
foreach(int item in arr)
Console.Write($"{item} ");
}

int Summ(int [] arr) 
{
    int result = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
       result += arr[i];
    }
    return result;
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.Write("Массив: ");
PrintArray(arr);

Console.WriteLine("");

Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
int count = Summ(arr);
Console.WriteLine(count);