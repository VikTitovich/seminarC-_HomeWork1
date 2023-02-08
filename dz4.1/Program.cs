// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     // int result = Math.Pow(numberA, numberB);
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);


  ///////////////////////////////////////////////////////////////
  Task_1();

  void Task_1()
  {
     ReadInt("Enter Number A:");
     int numberA = 0;
     //int.TryParse(Console.ReadLine(), out int numberA);
     ReadInt("Enter Degree B:");
     int numberB = 0;
     //int.TryParse(Console.ReadLine(), out int numberB);
    Exponent(numberA, numberB);

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

void Exponent (int numberA, int numberB)
{
  int result = 1;
  for(int i = 1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
    Console.WriteLine(result);
    
}

