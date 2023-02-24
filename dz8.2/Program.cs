// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//int numberLines = ReadInt("Enter Number Lines: ");

//int numberRows = ReadInt("Enter Number Rows: ");

int[,] array = new int[ReadInt("Enter Number Lines: "), ReadInt("Enter Number Rows: ")];

GetRandomArrayInt(array);

PrintArray(array);

int sumLine = SumLineElements(array, 0);

MinSumLine(sumLine);

void MinSumLine (int sumLine)
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
  int sumLine = array[i,0];

  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
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

