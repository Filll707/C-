﻿Console.WriteLine("Введите первое число для проверки");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
}
else if (numberB > numberA)
{
    Console.WriteLine($"Число {numberB} больше числа {numberA}");
}
else if (numberB == numberA)
{
    Console.WriteLine($"Числа равны");
}