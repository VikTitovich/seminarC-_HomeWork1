// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// Console.WriteLine("Введите трёхзначное число: ");

// int.TryParse(Console.ReadLine(), out int number);

// Console.WriteLine($"Вторая цифра числа {number} равна {(number / 10) % 10}");

//*********************************************************************************************


// Console.WriteLine("Введите трёхзначное число: ");

// bool isnumber = int.TryParse(Console.ReadLine(), out int number);

// if (isnumber) 
// {
// Console.WriteLine($"Вторая цифра числа {number} равна {(number / 10) % 10}");
// }
// else
// {
//     Console.WriteLine("Вы ввели не число.");
//}    


// *******************************************************************************************
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// ****************************************************************************************************

// Console.WriteLine("Введите число: ");

// int.TryParse(Console.ReadLine(), out int number);

// int i = 2;

// number =  number.ToString()[i] - '0';

// Console.WriteLine(number);


//***************************************************************************

// Console.WriteLine("Введите число: ");

// bool isnumber = int.TryParse(Console.ReadLine(), out int number);

// if (isnumber)
// {
// int digit = 0;

// if (number >= 100)
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     } 
//     digit = number % 10;
//     Console.WriteLine(digit);
// } 
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }
// }
// else
// {
//    Console.WriteLine("Вы ввели не число."); 
// }
//****************************************************************************
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет
//*****************************************************************************

Console.WriteLine("Введите день недели: ");
bool isnumber = int.TryParse(Console.ReadLine(), out int number);

if (isnumber)
{
    if ((number == 6) || (number == 7))
    {
      Console.WriteLine("Да");  
    } 
    else  if ((number >= 1) && (number <= 5))
        {
         Console.WriteLine("Нет");    
        }
    
            else 
            {
            Console.WriteLine("Дней в неделе только 7. Вы ввели неправильное число");
            }
 }
else 
{
   Console.WriteLine("Вы ввели не число.");  
}


