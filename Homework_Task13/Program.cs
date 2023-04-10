// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Enter any number: ");
int number = int.Parse(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
   Console.WriteLine("The third digit of the number is " +numberText[2]);
}
else 
{
    Console.WriteLine("There is no the third digit");
}
