/*Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число -> ");
double num = double.Parse(Console.ReadLine());

if ((num < 2) & (num > -2)) Console.WriteLine("Чётные числа в множестве от 1 до введённого вами числа отсутствуют");

int count = 2;

while(count <= Math.Abs(num))
{
 Console.Write(count + " ");
 count = count + 2;
}
/*второй способ
int num = int.Parse(numStr); // int num = Convert.ToInt32(numberStr); // равнозначные записи

if(int.TryParse(num))

//проверка на дурака
bool needToCastToInt = true;
while(needToCastToInt)
{
    Console.WriteLine("Введите Число:");
    string str = Console.ReadLine();

    if(int.TryParse(str, out int newNumber))

}
*/