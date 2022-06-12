/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/



int [] InitArray(int length) //метод, который инициализирует массив из 12 элементов в промежутке от [-9, 9]
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(1, 6); // [a,b)
}

return arr;
}


void PrintArray(int [] arr) //метод, который печатает наш массив на консоль
{
foreach(int item in arr)
Console.Write($"{item} ");
}

int [] Multiple (int [] array)
{
    int length = 0;
    bool even = false;
    
    if (array.Length % 2 == 0)
    {
        length = array.Length / 2;
        even = true;
    }
        
            
    else
    {
    length = (array.Length / 2) + 1;
    }
        
        
    int [] newArray = new int [length];
    for (int i = 0; i <= array.Length/2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    if (!even)
    {
        newArray[newArray.Length - 1] = array[(array.Length - 1)/2+1];
    }
    
    return newArray;
}


Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Массив:");
PrintArray(arr);


int [] result = Multiple(arr);
Console.WriteLine("Произведения пар чисел в одномерном массиве:");
PrintArray(result);