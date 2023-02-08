using System;
// 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// *************************************************************************************************************************
// System.Console.WriteLine("Введите число");

// int.TryParse(Console.ReadLine(), out int a);

// int b = 1;

// while(b <= a)
// {
//     System.Console.WriteLine(Math.Pow(b, 3));
//     b++;
// }
//////////////////////////////////////////////////////////////////////////////////////////////////////////
Task_1();

void Task_1()
{
    int number = ReadInt("number");

    int[] array = new int[number + 1];

    Cube(array);

    PrintMoreFromArray(array);
}

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument}");

    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }
    return number;
}

void Cube(int[] cube)
{
    int counter = 1;

    while (counter < cube.Length)
    {
        cube[counter] = (int)Math.Pow(counter, 3);
        counter++;
    }
}

void PrintMoreFromArray(int[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


