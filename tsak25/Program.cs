/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
 */

Console.WriteLine("Введите 2 числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberInPower = numberA;

for (int i = 1; i < numberB; i++)
{
    numberInPower = numberInPower * numberA;
}
Console.WriteLine(numberInPower);