Console.WriteLine("Введите первое число для проверки");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для проверки");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число для проверки");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
{
    Console.WriteLine($"Число {max} является максимальным из трех чисел {numberA}, {numberB}, {numberC}");
}


