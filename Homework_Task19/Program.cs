// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Enter five-digit number: ");
string number = Console.ReadLine();

void Polindrom (string number)

{
    if (number [0] == number [4] || number [1] == number [3]) 
    {
       System.Console.WriteLine("This number is polindrom");
    }
    else if (number.Length > 5)
    {
       System.Console.WriteLine("Eror! Enter the number one more time!");
    }
    else
    {
      System.Console.WriteLine("This number is not polindrom");
    }
}
Polindrom(number);
