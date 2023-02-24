// 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//----------------------------------------------------------------------------------------------------------------------------
//
// 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//----------------------------------------------------------------------------------------------------------------------------
//
// 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//----------------------------------------------------------------------------------------------------------------------------

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
                    int[,] array = new int[ReadInt("Enter Number Lines: "), ReadInt("Enter Number Rows: ")];

                    GetRandomArrayInt(array);

                    PrintArray(array);

                    Console.WriteLine($"{Environment.NewLine}New Array:");

                    OrderArrayLines(array);

                    PrintArray(array);

                    Console.WriteLine();

                    break;
                }
            case 2:
                {
                    int[,] array = new int[ReadInt("Enter Number Lines: "), ReadInt("Enter Number Rows: ")];

                    GetRandomArrayInt(array);

                    PrintArray(array);

                    int sumLine = SumLineElements(array, 0);

                    MinSumLine(sumLine, array);

                    Console.WriteLine();

                    break;
                }
            case 3:
                {
                    int[,] matrixOne = new int[ReadInt("Enter Number Lines 1 Matrix: "), ReadInt("Enter Number Rows 1 Matrix: ")];

                    GetRandomArrayInt(matrixOne);

                    Console.WriteLine($"{Environment.NewLine}First Matrix:");

                    PrintArray(matrixOne);

                    Console.WriteLine();

                    int[,] matrixSecond = new int[matrixOne.GetLength(1), ReadInt("Enter Number Rows 2 Matrix: ")];

                    GetRandomArrayInt(matrixSecond);

                    Console.WriteLine($"{Environment.NewLine}Second Matrix:");

                    PrintArray(matrixSecond);

                    int[,] matrixResult = new int[matrixOne.GetLength(0), matrixSecond.GetLength(1)];

                    MatrixMultiply(matrixOne, matrixSecond, matrixResult);

                    Console.WriteLine($"{Environment.NewLine}Matrix Multiply Result:");

                    PrintArray(matrixResult);

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

void OrderArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];

                    array[i, k + 1] = array[i, k];

                    array[i, k] = temp;
                }
            }
        }
    }
}

void MinSumLine(int sumLine, int[,] array)
{
    int minSumLine = 0;

    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (sumLine > SumLineElements(array, i))
        {
            sumLine = SumLineElements(array, i);

            minSumLine = i;
        }
    }
    Console.WriteLine($"{Environment.NewLine}{minSumLine + 1} - Line With Min Sum Elements ({sumLine})");
}

int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];

    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void MatrixMultiply(int[,] matrixOne, int[,] matrixSecond, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                sum += matrixOne[i, k] * matrixSecond[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }
}