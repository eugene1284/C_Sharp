/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

char [] ConvertingToBinary (int number)
{
    string remainder = string.Empty;
    while (number >= 1)
    {
    int ost = number % 2;
    remainder += ost.ToString();
    number = number / 2;
    }
    return remainder.Reverse().ToArray();
}

void PrintArray (char [] binaryNumber)
{
    for(int i = 0; i < binaryNumber.Length; i++)
    {
        Console.Write(binaryNumber[i]);
    }
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
char [] binaryNumber = ConvertingToBinary(number);
PrintArray(binaryNumber);