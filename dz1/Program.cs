bool isWork = true;

while (isWork)
{
    Console.Write("Enter a number of task ");

    if (int.TryParse(Console.ReadLine(), out int j))
    {
        switch (j)
        {
            case 1:
                {
                    Console.WriteLine("Enter a first number: ");

                    int.TryParse(Console.ReadLine(), out int number);

                    Console.WriteLine("Enter a second number: ");

                    int.TryParse(Console.ReadLine(), out int number1);

                    if (number > number1)
                    {
                        Console.WriteLine($"First max = {number}");
                    }
                    else
                        Console.WriteLine("Second max = {number1}");

                    break;
                }
            case 2:
                {

                    Console.WriteLine("Enter a first number: ");

                    int.TryParse(Console.ReadLine(), out int number);

                    Console.WriteLine("Enter a second number: ");

                    int.TryParse(Console.ReadLine(), out int number1);

                    Console.WriteLine("Enter a third number: ");

                    int.TryParse(Console.ReadLine(), out int number2);

                    int max = number;

                    if (number1 > max) max = number1;

                    if (number2 > max) max = number2;

                    Console.WriteLine($"max = {max}");

                    break;

                }
            case 3:
                {

                    Console.WriteLine("Enter a number: ");

                    int.TryParse(Console.ReadLine(), out int number);

                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} - even number"); //чётное
                    }
                    else Console.WriteLine($"{number} - odd number"); //нечётное

                    break;

                }
            case 4:
                {
                    Console.WriteLine("Enter a number: ");

                    int.TryParse(Console.ReadLine(), out int N);

                    for (int i = 1; i <= N; i++)
                    {
                        if (i % 2 == 0) Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                    break;

                }

            case -1: isWork = false; break;
        }
    }
}
