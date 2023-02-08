using System.Globalization;
// *************************************************************************************************************************
// 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// *************************************************************************************************************************

Task_1();

void Task_1()
{
    Console.WriteLine("Input Number");

    string number = Console.ReadLine();

    if (number.Length == 5)
    {
        CheckPalindrom(number);
    }
    else
    {
        Console.WriteLine($"Error! Enter five-digit number");
    }
}

void CheckPalindrom(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"Your Number: {number} - palindrom.");
    }
    else
    {
        Console.WriteLine($"Your Number: {number} - none palindrom.");
    }
}

