// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter any three-digit number: ");
int number = int.Parse(Console.ReadLine());
string numberText = Convert.ToString(number);
Console.WriteLine("The second digit of the number is " +numberText[1]);
