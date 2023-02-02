// ********************************************************************************************************
// 1. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// ********************************************************************************************************
// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// ********************************************************************************************************

// 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет
// ********************************************************************************************************

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
                    Console.WriteLine("Enter three-digit number: ");

                    bool isnumber = int.TryParse(Console.ReadLine(), out int number);

                    if (isnumber)
                    {
                        if ((number >= 100) && (number < 999))
                        {
                            Console.WriteLine($"The second digit of the number {number} is {(number / 10) % 10}");
                        }
                        else
                        {
                            Console.WriteLine("You didn't enter a three-digit number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a number.");
                    }
                    break;
                }


            case 2:
                {
                    Console.WriteLine("Enter number: ");

                    bool isnumber = int.TryParse(Console.ReadLine(), out int number);

                    if (isnumber)
                    {
                        int digit = 0;

                        if (number >= 100)
                        {
                            while (number > 999)
                            {
                                number = number / 10;
                            }
                            digit = number % 10;
                            Console.WriteLine($"Third digit is {digit}");
                        }
                        else
                        {
                            Console.WriteLine("There is no third digit");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a number.");
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Enter the day of the week: ");
                    bool isnumber = int.TryParse(Console.ReadLine(), out int number);

                    if (isnumber)
                    {
                        if ((number == 6) || (number == 7))
                        {
                            Console.WriteLine("Yes");
                        }
                        else if ((number >= 1) && (number <= 5))
                        {
                            Console.WriteLine("No");
                        }

                        else
                        {
                            Console.WriteLine("There are only 7 days in a week. You entered the wrong number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a number.");
                    }
                    break;
                }
            case -1: isWork = false; break;
        }
    }
}


