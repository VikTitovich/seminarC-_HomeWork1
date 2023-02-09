// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine(CalculateSumNumbers(ReadInt("number")));

int ReadInt(string argument)
{
    Console.WriteLine($"Input {argument} ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number. Try again.");
    }

    return number;
}

int CalculateSumNumbers(int number)
{
    int sum = 0;
    int counter = 0;

    while (number != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
        counter++;
    }
    return sum;
}