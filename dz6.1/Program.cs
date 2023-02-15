// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3




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

int[] EnterArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ReadInt($"Enter {i + 1} element: ");
    }
    return array;
}

int GetCount(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = ReadInt("Enter number elements: ");

int[] array = new int[length];

array = EnterArray(length);

Console.WriteLine($"Your Array [{string.Join(", ", array)}]");

Console.WriteLine($"{GetCount(array)} positive element(s)");

