// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = ReadInt("Enter Number M: ");

int n = ReadInt("Enter Number N: ");

int f = Ackkerman(m, n);

Console.Write($"{Environment.NewLine}A({m}, {n}) = {f} ");

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

int Ackkerman(int m, int n)
{
  if (m == 0) return n + 1;

  else if (n == 0) return Ackkerman(m - 1, 1);

  else return Ackkerman(m - 1, Ackkerman(m, n - 1));
}