/*Задача 39: 
Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

/*
1. метод, который инициализирует массив случайными числами
2. метод, который печатает массив на консоль
3. метод, который переворачивает массив наоборот
*/

//метод, который инициализирует массив случайными числами
int [] GetArray(int length)
{
int[] array = new int [length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    array[i] = rnd.Next(1, 15);
}
return array;
}

//метод, который печатает массив на консоль
void PrintArray(int[] array)
{
foreach(int item in array)
{
Console.Write($"{item} ");
}
}

//метод, который переворачивает массив наоборот и возвращает новый массив
int [] ReverseArray(int[] array)
{
//array.Reverse();
int[] result = new int[array.Length];
int resultCount = 0;

for(int i = array.Length - 1; i>= 0; i--)
{
    result[resultCount] = array[i];
    resultCount++;
}
return result;
}

//перевернет массив сам себя
void ReverseArraySelf(int[] array)
{
array.Reverse();
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());

int [] array = GetArray(length);
PrintArray(array);
Console.WriteLine();

int [] reversedArr = ReverseArray(array);
PrintArray(reversedArr);