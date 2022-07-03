int GetRandomNumber(int minBorder, int maxBorder)
{
    return new Random().Next(minBorder, maxBorder + 1);

}
int getMaxDigit(int number)
{
    int result = 0;
    number = Math.Abs(number);
    if (number > 10 && number < 100)
    {
        int digitOne = number / 10;
        int digitTwo = number % 10;
        result = digitOne;
        if (result < digitTwo)
        {
            result = digitTwo;
        }
    }
    else
    {
        Console.WriteLine($"Число {number} не в границе [10,99]");
    }
    return result;
}
int randomNumber = GetRandomNumber(10, 99);
int maxDigit = getMaxDigit(randomNumber);
Console.WriteLine($"Наибольшая цифра числа {randomNumber} это {maxDigit}");
