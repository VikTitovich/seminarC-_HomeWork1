// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
//степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//*********************************************************************************************

Task_1();

void Task_1()
{
    int result = Exponent(ReadInt("Enter Number A:"), ReadInt("Enter Degree B:"));

    Console.WriteLine(result);

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

int Exponent(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = (int)Math.Pow(numberA, numberB);

    }
    return result;
}

