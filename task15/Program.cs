﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void dayOfWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Введите значение от 1 до 7");
    }
    else Console.WriteLine("Этот день не выходной");
}
dayOfWeek(dayNumber);