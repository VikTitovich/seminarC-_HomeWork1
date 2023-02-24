//1. Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//---------------------------------------------------------------------------------

// 2. Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
//---------------------------------------------------------------------------------

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
//---------------------------------------------------------------------------------

using System.Linq;
bool isWork = true;

while (isWork)
{
    Console.WriteLine("Enter Number of Task, 1, 2, 3 or -1: Exit Program: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    int n = ReadInt("Enter Number N: ");

                    int counter = 2;

                    PrintNumber(n, counter);

                    Console.Write(1);

                    Console.WriteLine();

                    break;
                }
            case 2:
                {
                    int m = ReadInt("Enter Number M: ");

                    int n = ReadInt("Enter Number N: ");

                    int sum = 0;

                    PrintSum(m, n, sum);

                    Console.WriteLine();

                    break;
                }
            case 3:
                {
                    int m = ReadInt("Enter Number M: ");

                    int n = ReadInt("Enter Number N: ");

                    Console.Write($"{Environment.NewLine}A({m}, {n}) = {Ackkerman(m, n)} ");

                    Console.WriteLine();

                    break;
                }

            case -1: isWork = false; break;
        }
    }
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

void PrintNumber(int n, int count)
{
    if (count > n) return;

    PrintNumber(n, count + 1);

    Console.Write(count + ", ");
}

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

int Ackkerman(int m, int n)
{
    if (m == 0) return n + 1;

    else if (n == 0) return Ackkerman(m - 1, 1);

    else return Ackkerman(m - 1, Ackkerman(m, n - 1));
}