/* 
Задача 36: 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 
*/

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-500, 500);
    }
}
void PrintArray(int[] array2)
{
    Console.Write("[ ");
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.Write("]");
}
int sumOddNumbers(int[] array3)
{
    int sum = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array3[i];
        }
    }
    return sum;
}
Console.WriteLine("Введите количество элементов массива:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum = sumOddNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива равна {sum}");
