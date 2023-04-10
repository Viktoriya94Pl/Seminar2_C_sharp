// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Enter the number that represents the day of the week: ");
int dayNumber = int.Parse(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
{
   Console.WriteLine("Its a holiday");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Its not day of the week at all");
}
else 
{
    Console.WriteLine("Its not a holiday");
}
