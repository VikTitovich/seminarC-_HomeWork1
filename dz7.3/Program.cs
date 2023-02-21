// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int numberLines = ReadInt("Enter Number Lines: ");

int numberRows = ReadInt("Enter Number Rows: ");

int[,] array = new int[numberLines, numberRows];

GetRandomArrayInt(array);

PrintArray(array);

Console.Write($"\nArithmetic mean:\n");

Arithmetic(array);

void Arithmetic(int[,] array)
{
    for (int i = 0; i < numberRows; i++)
    {
        double sum = 0;
        for (int j = 0; j < numberLines; j++)
        {
            sum += array[j, i];
        }
        sum = Math.Round(sum / numberLines, 1);

        Console.WriteLine($"column {i} = {sum}");
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

void GetRandomArrayInt(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < numberLines; i++)
    {
        for (int j = 0; j < numberRows; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

