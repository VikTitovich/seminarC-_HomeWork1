// 1. Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
//------------------------------------------------------------------------------

// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//------------------------------------------------------------------------------

// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//------------------------------------------------------------------------------

using System.Linq;
bool isWork = true;

while (isWork)
{
    Console.WriteLine("Enter NUmber of Task, 1, 2, 3 or -1: Exit Program: ");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    int[] array = GetRandomArray(6, 100, 1000);

                    int count = GetCountEvenNumbers(array);

                    Console.WriteLine($"In Your Array [{string.Join(", ", array)}] : {count} even element(s)");

                    Console.WriteLine();

                    break;
                }
            case 2:
                {
                    int[] array = GetRandomArray(6, 10, 100);

                    int sum = GetSumOddIndex(array);

                    Console.WriteLine($"In Your Array [{string.Join(", ", array)}] : sum odd elements = {sum} ");

                    Console.WriteLine();

                    break;
                }
            case 3:
                {
                    double[] array = GetRandomArrayDouble(6, 10, 100);

                    double diff = GetDiffMaxMin(array);

                    Console.WriteLine($"In Your Array [{string.Join(", ", array)}] : max - min = {diff}");

                    Console.WriteLine();
                    break;
                }

            case -1: isWork = false; break;
        }
    }
}

int[] GetRandomArray(int length, int minValue, int maxValue)               //Random int
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

double[] GetRandomArrayDouble(int length, int minValue, int maxValue)       //Random double
{
    double[] array = new double[length];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int GetCountEvenNumbers(int[] array)                                        //Счётчик чётных чисел в массиве
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1)
        {
            count++;
        }
    }
    return count;
}

int GetSumOddIndex(int[] array)                                           //Сумма элементов с нечётными индексами
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

double GetDiffMaxMin(double[] array)                                     //Разница между max и min 
{
    double maxNumber = array[0];

    double minNumber = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    return maxNumber - minNumber;
}
