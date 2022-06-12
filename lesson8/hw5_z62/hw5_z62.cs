/*
Задача 62: Заполните спирально массив 4 на 4.
1  2  3  4 
12 13 14 5
11 16 15 6
10 9  8  7
*/
class Program
{
    struct Direction
    {
        public int i;
        public int j;
    }
    static int StaticNumberInput(string text)//Метод ввода и проверки на число
    {
        bool isInputInt = true;
        int number = 0;
        while (isInputInt)
        {
            Console.Write($"Введите {text} :");
            string numberSTR = Console.ReadLine();
            if (int.TryParse(numberSTR, out int numberInt))
            {
                if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
                else
                {
                    number = numberInt;
                    isInputInt = false;
                }
            }
            else
                Console.WriteLine("Ввели не число");
        }
        return number;
    }

    static void Main(string[] args)
    {
        int n = StaticNumberInput("кол-во строк");
        int m = StaticNumberInput("кол-во столбцов");

        int[,] array = new int[n, m];
        Direction direct = new Direction() { i = 0, j = 1 };
        int count = 0;

        int i = 0, j = 0;
        while (count < n * m)
        {
            while ((i < n) && (i >= 0) && (j < m) && (j >= 0))
            {
                if (array[i, j] == 0)
                {
                    count++;
                    array[i, j] = count;
                    i += direct.i;
                    j += direct.j;
                }
                else
                {
                    if (count == m * n) break;
                    i -= direct.i;
                    j -= direct.j;
                    ChangeDirection(ref direct);
                    i += direct.i;
                    j += direct.j;
                }
            }

            if (i < 0) i = 0;
            if (i >= n) i = n - 1;
            if (j < 0) j = 0;
            if (j >= m) j = m - 1;
            ChangeDirection(ref direct);
            i += direct.i;
            j += direct.j;
        }

        Console.WriteLine("Результат:");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                Console.Write("{0:00} ", array[i, j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    static void ChangeDirection(ref Direction direct)
    {
        switch (direct.i)
        {
            case -1:
                direct.i = 0;
                direct.j = 1;
                break;
            case 1:
                direct.i = 0;
                direct.j = -1;
                break;
            case 0:
                if (direct.j > 0)
                {
                    direct.i = 1;
                    direct.j = 0;
                }
                else
                {
                    direct.i = -1;
                    direct.j = 0;
                }
                break;
        }
    }
}