/* 
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

void FillArray(int[] anyArray)
{
    for (int i = 0; i < anyArray.Length; i++)
    {
        anyArray[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] anyArray2)
{
    Console.Write("[ ");
    for (int i = 0; i < anyArray2.Length; i++)
    {
        Console.Write($"{anyArray2[i]} ");
    }
    Console.Write("]");
}
int evenNumbers(int[] anyArray3)
{
    int quantity = 0;
    for (int i = 0; i < anyArray3.Length; i++)
    {
        if (anyArray3[i] % 2 == 0)
        {
            quantity += 1;
        }
    }
    return quantity;
}
Console.WriteLine("Введите количество элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int quantity = evenNumbers(array);
System.Console.WriteLine($"Количество четных чисел в массиве: {quantity}");

