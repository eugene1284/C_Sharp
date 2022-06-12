/*Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

void GetSquar(int N)
{
    foreach (int ind in Enumerable.Range( 1, N ))
    //foreach (int ind in Range(1, N))
    System.Console.Write($"{ind * ind}, ");
    
}

int GetNumber(string msg)
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if (number > 0)
                return number;
            else
            {
                Console.WriteLine("Число должно быть больше 0. Введите другое число");
            }
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число, отличное от нуля.");
        }
    }
}

string messageI = "Введите N ";
int sqr = GetNumber(messageI);


GetSquar(sqr);