//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

bool isWork = true;

while (isWork)
{
    Console.WriteLine("Enter Array Input Method, 1: Random, 2: By User, -1: Exit Program: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Console.WriteLine("Enter a Range of Array Values: \nfrom: ");
                    int numberA = int.Parse(Console.ReadLine());
                    Console.WriteLine("before: ");
                    int numberB = int.Parse(Console.ReadLine());
                    FillArrayRandom(array, numberA, numberB);
                    PrintArray(array);
                    Console.WriteLine();
                    break;
                }
            case 2:
                {
                    FillArrayByUser(array);
                    PrintArray(array);
                    Console.WriteLine();
                    break;
                }

            case -1: isWork = false; break;
        }
    }
}

void FillArrayByUser(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter {i} element of massiv");
        array[i] = int.Parse(Console.ReadLine());
    }
}

void FillArrayRandom(int[] array, int numberA, int numberB)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(numberA, numberB);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
