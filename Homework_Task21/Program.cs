// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

double XYZRange()
{
Console.WriteLine("Enter number x for A: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number y for A: ");
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number z for A: ");
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number x for B: ");
double x2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number y for B: ");
double y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number z for B: ");
double z2 = double.Parse(Console.ReadLine());
double result = Math.Sqrt(((Math.Pow((x2 - x1), 2))) + (Math.Pow((y2- y1), 2) + (Math.Pow((z2- z1), 2))));
return result;
}
System.Console.WriteLine($"Rastoyanie = {XYZRange()}");
