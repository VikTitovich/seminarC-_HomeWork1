bool isWork = true;

while (isWork)
{
	Console.Write("Enter a number of task ");

	if (int.TryParse(Console.ReadLine(), out int j))
	{
		switch (j)
		{
			case 1:
			{
				Console.WriteLine("Введите 1-ое число: ");

                int.TryParse(Console.ReadLine(), out int number);

                Console.WriteLine("Введите 2-ое число: ");

                int.TryParse(Console.ReadLine(), out int number1);

                if (number > number1)
                {
                Console.WriteLine("1 max и равно " + number);
                }
                else 
                Console.WriteLine("2 max и равно " + number1);

				break;
			}
			case 2:
			{
				
                Console.WriteLine("Введите 1-ое число: ");

                int.TryParse(Console.ReadLine(), out int number);

                Console.WriteLine("Введите 2-ое число: ");

                int.TryParse(Console.ReadLine(), out int number1);

                Console.WriteLine("Введите 3-ое число: ");

                int.TryParse(Console.ReadLine(), out int number2);

                int max = number;

                if (number1 > max) max = number1;

                if (number2 > max) max = number2;
    
                Console.WriteLine("max - " + max);

                break;
				
			}
            case 3:
			{
				
                Console.WriteLine("Введите число: ");

                int.TryParse(Console.ReadLine(), out int number);
 
                if (number % 2 == 0)
                {
                Console.WriteLine("Чётное");
                }
                else  Console.WriteLine("Нечётное");

                break;
				
			}
            case 4:
			{
				Console.WriteLine("Введите число: ");

                int.TryParse(Console.ReadLine(), out int N);

                for (int i = 1; i <= N; i++)
                {
                if (i % 2 == 0) Console.Write(i + " ");
                }
                Console.WriteLine();
                break;
				
			}

			case -1: isWork = false; break;
		}
	}
}
