/* Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 
*/

Console.WriteLine("Введите последовательно несколько чисел через запятую");
string textNumber = Console.ReadLine();

string convertedText(string text, char oldChar, string Empty)
{
    string removeSimbolsFromText = string.Empty;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == oldChar)
        {
            removeSimbolsFromText = removeSimbolsFromText + $"{Empty}";
        }
        else
            removeSimbolsFromText = removeSimbolsFromText + $"{text[i]}";
    }
    return removeSimbolsFromText;
}

int countOfPositiveNumbers(int[] digitalArray)
{
    int count = 0;
    for (int i = 0; i < digitalArray.Length; i++)
    {
        if (digitalArray[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

string textWithoutSpaces = convertedText(textNumber, ' ', string.Empty);
int[] digitalArray = textWithoutSpaces.Split(',').Select(int.Parse).ToArray();
int countOfPlusNumbers = countOfPositiveNumbers(digitalArray);

if (countOfPlusNumbers == 1)
{
    Console.WriteLine($"вы ввели {countOfPlusNumbers} число больше 0");
}
else if (countOfPlusNumbers > 1 && countOfPlusNumbers < 5)
{
    Console.WriteLine($"вы ввели {countOfPlusNumbers} числа больше 0");
}
else if (countOfPlusNumbers == 0 || countOfPlusNumbers > 4)
{
    Console.WriteLine($"вы ввели {countOfPlusNumbers} чисел больше 0");
}
