/*Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/


int [] InitArray(int length)  //метод, который инициализирует массив из length элементов в промежутке от [-9, 9]
{
    //length12515asgagzxvas = length, значимый тип, value type
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-9, 10); // [a,b)
}

return arr;
}

int [] MultipleNegative(int [] array) // метод, который умножает каждый элемент массива на -1
{
    int [] newArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
       newArray[i] = array[i] * (-1);
    }
    return newArray;
}

//метод, который печатает массив на консоль
void PrintArray(int [] arr)
{
foreach(int item in arr)
Console.Write($"{item} ");
}


Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);
Console.WriteLine("Массив:");
PrintArray(arr);
Console.WriteLine();
// arr [0] = 25; // Для понимания 

int[] array = MultipleNegative(arr);
Console.WriteLine("Преобразованный массив:");
PrintArray(array);