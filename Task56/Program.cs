/* 
Задача 56.
Задайте прямоугольный двумерный массив.
Напишите программу которая будет находить строку
с наименьшей суммой элементов
Например:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдает 
номер строки с наименьшей суммой элементов: 1 строка 
*/

int[,] fillRandomSquareArray(int rowsCount)
{
    int[,] resultArray = new int[rowsCount, rowsCount];
    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < rowsCount; j++)
        {
            resultArray[i, j] = new Random().Next(1, 10);
        }
    }
    return resultArray;
}
void PrintArray(int[,] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayForPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[] rowsSumArray(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = array[i, j] + sum;
        }
        resultArray[i] = sum;
        sum = 0;
    }
    return resultArray;
}
int minIndex(int[] array)
{
    int result = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
            minIndex = i;
        }
    }
    return minIndex + 1;
}
int[,] array = fillRandomSquareArray(4);
PrintArray(array);
Console.WriteLine();
int[] sumOfRowsArray = rowsSumArray(array);
int indexMinSum = minIndex(sumOfRowsArray);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {indexMinSum}");