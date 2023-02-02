//************************************************************************
// 1.Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
//************************************************************************

// 2. Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//************************************************************************

// Напишите программу, которая на вход принимает число и выдаёт, является 
// ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//************************************************************************
// Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//************************************************************************

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
