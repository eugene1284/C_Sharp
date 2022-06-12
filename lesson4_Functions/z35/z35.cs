/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

//метод, который заполняет элементы массива размерностью, который ввёл пользователь в length, 
//случайными элементами в определённом диапазоне
int [] InitArray(int length) 
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-200, 200);
}

return arr;
}

int FindNumbers (int [] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99))
            count ++;
    }
    return count;
}

//метод, который печатает массив на консоль
void PrintArray(int [] arr)
{
foreach(int item in arr)
Console.Write($"{item} ");
}


Console.WriteLine("Введите размерность массива (по условию задачи необходимо ввести 123)");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintArray(arr);
Console.WriteLine("");

Console.WriteLine($"Количество элементов массива, которое входит в диапазон [10,99]: {FindNumbers(arr)}");