/*
Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
1, 2, 3 
4, 6, 1 
2, 1, 6
1 встречается 3 раза 
2 встречается 2 раз 
3 встречается 1 раз 
4 встречается 1 раз 
6 встречается 2 раза

можно решить через структуру данных dictionary

*/

int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] FillArray(int firstDemension, int secondDemention)
{
    Random rnd = new Random();
    int[,] arr = new int[firstDemension, secondDemention];
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemention; j++) arr[i, j] = rnd.Next(0, 10);
    }
    return arr;
}


// 1 2 3 4
// 4 5 6 7


void PrintArray(int[,] arr)
{
    int[] array = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {    
            array[arr[i,j]] ++;
            System.Console.Write(arr[i,j]);
        }   
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]!=0)
            System.Console.WriteLine($"{i} встречается {array[i]} раз");
    }
}


Console.Clear();
//System.Console.WriteLine("Введите диапазон");
//int cound = int.Parse(System.Console.ReadLine());
int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arr = FillArray(firstDemension, secondDemention);
System.Console.WriteLine();
System.Console.WriteLine("массив чисел");
PrintArray(arr);
Console.ReadKey();