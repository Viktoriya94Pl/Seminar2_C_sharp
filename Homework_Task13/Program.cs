// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Enter any number: ");
// int number = int.Parse(Console.ReadLine());
// string numberText = Convert.ToString(number);
// if (numberText.Length > 2)
// {
//    Console.WriteLine("The third digit of the number is " +numberText[2]);
// }
// else 
// {
//     Console.WriteLine("There is no the third digit");
// }

int digit = GetDigitFromNumber(ReadInt(), ReadInt());

if (digit != -1)
{
	Console.WriteLine(digit);
}
else
{
	Console.WriteLine("OOps");
}


int GetDigitFromNumber(int number, int digitPosition)
{
	number = Math.Abs(number);

	if (number < Math.Pow(10, digitPosition - 1)) // 100
	{
		return -1; // -1 - эТо ошибка.
	}

	while (number > Math.Pow(10, digitPosition))
	{
		number /= 10;
	}

	return number % 10;
}

int ReadInt()
{
	Console.WriteLine("Input number");
	return int.Parse(Console.ReadLine());
}