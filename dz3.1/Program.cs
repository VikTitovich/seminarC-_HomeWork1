// *************************************************************************************************************************
// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Enter five-digit number: ");

                    bool isnumber = int.TryParse(Console.ReadLine(), out int number);

                    if (isnumber)
                    {
                        if ((number >= 10000) && (number < 99999))
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