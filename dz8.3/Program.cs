// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MatrixMultiply(int[,] matrixOne, int[,] matrixSecond, int[,] matrixResult)
{
  for (int i = 0; i < matrixResult.GetLength(0); i++)
  {
    for (int j = 0; j < matrixResult.GetLength(1); j++)
    {
      int sum = 0;

      for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
        sum += matrixOne[i,k] * matrixSecond[k,j];
      }
      matrixResult[i,j] = sum;
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
