/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


void FillArray(int[] anyArray)
{
    for (int index = 0; index < anyArray.Length; index++)
    {
        anyArray[index] = new Random().Next(1, 99);
    }
}
void PrintArray(int[] anyArray)
{
    Console.Write("[");
    for (int index = 0; index < anyArray.Length; index++)
    {
        Console.Write($"{anyArray[index]}");
        if (index < anyArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
