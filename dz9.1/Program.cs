// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = ReadInt("Enter Number N: ");

int counter = 2;

PrintNumber(n, counter);

Console.Write(1);

int ReadInt(string argument)
{
    Console.Write(argument);

    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }
    return number;
}

void PrintNumber(int n, int count)
{
    if (count > n) return;

    PrintNumber(n, count + 1);

    Console.Write(count + ", ");
}