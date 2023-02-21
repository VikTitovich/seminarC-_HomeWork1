// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
//-----------------------------------------------------------------------------------------

// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
//-----------------------------------------------------------------------------------------

// 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
//-----------------------------------------------------------------------------------------

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
                    int numberLines = ReadInt("Enter Number Lines: ");

                    int numberRows = ReadInt("Enter Number Rows: ");

                    double[,] array = new double[numberLines, numberRows];

                    GetRandomArrayDouble(array);

                    WriteArray(array);

                    Console.WriteLine();

                    break;
                }
            case 2:
                {
                    int numberLines = ReadInt("Enter Number Lines: ");

                    int numberRows = ReadInt("Enter Number Rows: ");

                    double[,] array = new double[numberLines, numberRows];

                    GetRandomArrayDouble(array);

                    WriteArray(array);

                    Console.WriteLine();

                    int indexFirst = ReadInt("Enter First Index: ");

                    int indexSecond = ReadInt("Enter Second Index: ");

                    GetNumberFromIndex(array, indexFirst, indexSecond);

                    Console.WriteLine();

                    break;
                }
            case 3:
                {
                    int numberLines = ReadInt("Enter Number Lines: ");

                    int numberRows = ReadInt("Enter Number Rows: ");

                    int[,] array = new int[numberLines, numberRows];

                    GetRandomArrayInt(array);

                    PrintArray(array);

                    Console.Write($"\nArithmetic Mean:\n");

                    Arithmetic(array);

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

void GetRandomArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void WriteArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}

void GetNumberFromIndex(double[,] array, int indexFirst, int indexSecond)
{
    if (indexFirst <= array.GetLength(0)
    && indexSecond <= array.GetLength(1)
    && indexFirst >= 0
    && indexSecond >= 0)
    {
        double result = Math.Round(array[indexFirst - 1, indexSecond - 1], 1);
        Console.Write($"Element Value With Index [{indexFirst}, {indexSecond}] = {result}");
    }
    else Console.Write($"There is no Such Element in the Array.");
}

void Arithmetic(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        sum = Math.Round(sum / array.GetLength(0), 1);

        Console.WriteLine($"column {i} = {sum}");
    }
}

void GetRandomArrayInt(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}