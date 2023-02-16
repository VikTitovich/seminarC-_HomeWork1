// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//-------------------------------------------------------------------------------------------------

// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//-------------------------------------------------------------------------------------------------

using System.Linq;
bool isWork = true;

double[,] argument = new double[2, 2];

double[] crossPoint = new double[2];

while (isWork)
{
    Console.WriteLine("Enter NUmber of Task, 1, 2 or -1: Exit Program: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    int length = ReadInt("Enter number elements: ");

                    int[] array = new int[length];

                    array = EnterArray(length);

                    Console.WriteLine($"Your Array [{string.Join(", ", array)}]");

                    Console.WriteLine($"{GetCount(array)} positive element(s)");

                    Console.WriteLine();

                    break;
                }
            case 2:
                {
                    InputArguments();

                    OutputPoint(argument);

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

int[] EnterArray(int length)     
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Enter {i + 1} element: ");
    }
    return array;
}

int GetCount(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void InputArguments()
{
    for (int i = 0; i < argument.GetLength(0); i++)
    {
        Console.Write($"Input arguments for (y = k{i + 1} * x + b{i + 1}): ->\n");

        for (int j = 0; j < argument.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Input k{i + 1} -> ");

            else Console.Write($"Input b{i + 1} -> ");

            argument[i, j] = ReadInt("");
        }
    }
}

double[] Formula(double[,] argument)  //Вычисление точки пересечения прямых
{
    crossPoint[0] = (argument[1, 1] - argument[0, 1]) / (argument[0, 0] - argument[1, 0]);
    crossPoint[1] = crossPoint[0] * argument[0, 0] + argument[0, 1];
    return crossPoint;
}

void OutputPoint(double[,] argument) // Проверка на паралленость, совпадение прямых или пересечение
{
    if (argument[0, 0] == argument[1, 0] && argument[0, 1] == argument[1, 1])
    {
        Console.Write($"\nLines coincide");
    }
    else if (argument[0, 0] == argument[1, 0] && argument[0, 1] != argument[1, 1])
    {
        Console.Write($"\nLines Paralell");
    }
    else
    {
        Formula(argument);
        Console.Write($"\nLines Cross Point: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

