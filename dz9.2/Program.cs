
// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int m = ReadInt("Enter Number M: ");

int n = ReadInt("Enter Number N: ");

int sum = 0;

PrintSum(m, n, sum);

void PrintSum(int m, int n, int sum)
{
    sum = sum + n;

    if (n <= m)
    {
        Console.Write($"{Environment.NewLine}Elements Sum from M to N = {sum} ");

        return;
    }
    if (m > n)
    {
        sum = m;
        m = n;
        n = sum;
    }
    PrintSum(m, n - 1, sum);
}

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

