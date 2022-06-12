/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

/*
1. метод, который инициализирует массив из 12 элементов в промежутке от [-9, 9]
2. метод, который считает сумму положительных чисел
3. метод, который считает сумму отрицательных чисел
4. метод, который печатает наш массив на консоль
5*. метод, который возвращает сумму положительных + сумму отрицательных
*/


int [] InitArray(int length) //метод, который инициализирует массив из length элементов в промежутке от [-9, 9]
{
int [] arr = new int[length];
Random rnd = new Random();

for(int i = 0; i < length; i++)
{
    arr[i] = rnd.Next(-9, 10); // [a,b)
}

return arr;
}


int GetPositiveSummFromArray(int [] arr) // метод, который считает сумму положительных чисел
{
int summ = 0;

foreach(int item in arr)
{
    if(item > 0)
        summ += item; // += это тоже самое, что и summ = summ + item;
}

return summ;
}


int GetNegativeSummFromArray(int [] arr) //метод, который считает сумму отрицательных чисел
{
int summ = 0;

foreach(int item in arr)
{
    if(item < 0)
        summ += item; // += это тоже самое, что и summ = summ + item;
}

return summ;
}


void PrintArray(int [] arr) //метод, который печатает наш массив на консоль
{
foreach(int item in arr)
Console.Write($"{item} ");
}


(int, int) GetSummsFromArray(int [] arr) //метод, который возвращает сумму положительных + сумму отрицательных
{
int positiveSumm = 0;
int negativeSumm = 0;

foreach(int item in arr)
{
    if(item > 0)
        positiveSumm += item;
    else
        negativeSumm += item;
}

return (positiveSumm, negativeSumm);
}

Console.WriteLine("Введите размерность массива:");
int length = int.Parse(Console.ReadLine());
int[] arr = InitArray(length);

Console.WriteLine("Полученный массив:");
PrintArray(arr);

int positiveSumm = GetPositiveSummFromArray(arr);
int negativeSumm = GetNegativeSummFromArray(arr);

Console.WriteLine();
Console.WriteLine($"Положительная сумма: {positiveSumm}. Отрицательная сумма: {negativeSumm}");

(positiveSumm, negativeSumm) = GetSummsFromArray(arr);

Console.WriteLine("Вызвали метод под звездочкой");
Console.WriteLine($"Положительная сумма: {positiveSumm}. Отрицательная сумма: {negativeSumm}");