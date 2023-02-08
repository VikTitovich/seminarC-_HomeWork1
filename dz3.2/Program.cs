using System.ComponentModel;
// *************************************************************************************************************************
// 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// *************************************************************************************************************************
// Console.WriteLine("Введите коордитанты точки x1, y1, z1:");
// int x1 = int.Parse(Console.ReadLine());
// int y1 = int.Parse(Console.ReadLine());
// int z1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите коордитанты точки x2, y2, z2:");
// int x2 = int.Parse(Console.ReadLine());
// int y2 = int.Parse(Console.ReadLine());
// int z2 = int.Parse(Console.ReadLine());


// double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// Console.WriteLine($"Расстояние между точками равно = {result}");
// *************************************************************************************************************************

Task_1();

void Task_1()
{
    int[] array = new int[] { ReadInt("x1"), ReadInt("y1"), ReadInt("z1"), ReadInt("x2"), ReadInt("y2"), ReadInt("z2") };

    Result(array[0], array[1], array[2], array[3], array[4], array[5]);
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

void Result(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

    System.Console.WriteLine($"Distance Between Two Points in 3D = {Math.Round(result, 2)}");

}


