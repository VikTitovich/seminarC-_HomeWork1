// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = GetRandomArrayDouble(6, 10, 100);

double diff = GetDiffMaxMin(array);

Console.WriteLine($"In Your Array [{string.Join(", ", array)}] : max - min = {diff}");

double[] GetRandomArrayDouble(int length, int minValue, int maxValue)
{
    double[] array = new double[length];

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue +1);
    }
    return array;
}

double GetDiffMaxMin(double[] array)
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
