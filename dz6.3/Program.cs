// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] argument = new double[2, 2];
double[] crossPoint = new double[2];

int ReadInt(string argument)
{
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }
    return number;
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

double[] Formula(double[,] argument)
{
    crossPoint[0] = (argument[1, 1] - argument[0, 1]) / (argument[0, 0] - argument[1, 0]);
    crossPoint[1] = crossPoint[0] * argument[0, 0] + argument[0, 1];
    return crossPoint;
}

void OutputPoint(double[,] argument)
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

InputArguments();
OutputPoint(argument);