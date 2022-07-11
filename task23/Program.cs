/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int numberCubed = 0;

for (int i = 1; i <= number; i++)
{
    numberCubed = Convert.ToInt32(Math.Pow(i, 3));
    if (i < number)
    {
        Console.Write($"{numberCubed}, ");
    }
    else
    {
        Console.Write($"{numberCubed}.");
    }
}