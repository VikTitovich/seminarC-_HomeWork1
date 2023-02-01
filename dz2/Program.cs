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
                    Console.WriteLine("Введите трёхзначное число: ");

                    bool isnumber = int.TryParse(Console.ReadLine(), out int number);

                    if (isnumber)
                    {
                        Console.WriteLine($"Вторая цифра числа {number} равна {(number / 10) % 10}");
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число.");
                    }
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Введите число: ");

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
                            Console.WriteLine($"Третья цифра равна {digit}");
                        }
                        else
                        {
                            Console.WriteLine("Третьей цифры нет");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число.");
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Введите день недели: ");
                    bool isnumber = int.TryParse(Console.ReadLine(), out int number);

                    if (isnumber)
                    {
                        if ((number == 6) || (number == 7))
                        {
                            Console.WriteLine("Да");
                        }
                        else if ((number >= 1) && (number <= 5))
                        {
                            Console.WriteLine("Нет");
                        }

                        else
                        {
                            Console.WriteLine("Дней в неделе только 7. Вы ввели неправильное число");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число.");
                    }
                    break;
                }
            case -1: isWork = false; break;
        }
    }
}


