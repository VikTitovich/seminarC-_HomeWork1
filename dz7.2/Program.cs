// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int numberLines = ReadInt("Enter Number Lines: ");

int numberRows = ReadInt("Enter Number Rows: ");

double[,] array = new double[numberLines, numberRows];

GetRandomArrayDouble(array);

WriteArray(array);

Console.WriteLine();

int indexFirst = ReadInt("Enter First Index: ");

int indexSecond = ReadInt("Enter Second Index: ");

GetNumberFromIndex(array);

void GetNumberFromIndex (double[,] array)
{
if (indexFirst <= numberLines -1 //+ 1
&& indexSecond <= numberRows - 1//+ 1
&& indexFirst >= 0 
&& indexSecond >= 0)
{
    double result = Math.Round(array[indexFirst, indexSecond], 1);
    Console.Write($"Element Value With Index [{indexFirst}, {indexSecond}] = {result}");
}
else Console.Write($"There is no Such Element in the Array.");
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
