// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = ReadInt("Enter number m: ");

int n = ReadInt("Enter number n: ");

double[,] array = new double[m, n];

GetRandomArrayDouble(array);

WriteArray(array);

Console.WriteLine();


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

void GetRandomArrayDouble (double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
           array[i, j] = new Random().NextDouble() * 20 - 10; 
        }
    }
}

void WriteArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}


