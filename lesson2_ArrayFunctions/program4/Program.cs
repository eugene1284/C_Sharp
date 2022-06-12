/* Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно и 7 и 23");
}

else
{
    Console.WriteLine($"Число {num} не кратно и 7 и 23 одновременно");   
}